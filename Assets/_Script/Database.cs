using Firebase.Database;
using Firebase;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Firebase.Extensions;
using UnityEngine.SceneManagement;

public class Database : MonoBehaviour
{
    public DependencyStatus dependencyStatus;
    private DatabaseReference reference;
    FirebaseApp app;
    public TMP_Text debug;

    public Transform scrollViewContent;
    public GameObject levelCardPrefab;
    List<Sprite> levelCards;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        LevelCard();
    }
    void LevelCard()
    {
        StartCoroutine(WaitForLevelId());
    }

    private IEnumerator WaitForLevelId()
    {
        // Wait for Firebase setup to complete
        yield return new WaitUntil(() => reference != null);

        if (reference != null)
        {
            GetLevelId();
        }
        else
        {
            debug.text = "no reference";
        }
    }

    void Awake()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });

    }

    private void InitializeFirebase()
    {
        FirebaseApp app = FirebaseApp.DefaultInstance;
        reference = FirebaseDatabase.GetInstance("https://nasa-af2d0-default-rtdb.firebaseio.com/").RootReference;

    }


    void GetLevelId()
    {
        reference.Child("News").GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted || task.IsCanceled)
            {
                Debug.LogError("Failed to retrieve data from Firebase.");
                return;
            }
            DataSnapshot snapshot = task.Result;
            foreach (var level in snapshot.Children)
            {
                GameObject card = Instantiate(levelCardPrefab, scrollViewContent);
                card.TryGetComponent<NewsCardProperty>(out NewsCardProperty property);
                property.SetProperty(level.Child("title").Value.ToString(), level.Child("date").Value.ToString(), level.Child("url").Value.ToString());
            }
        }

        );
    }

   
}