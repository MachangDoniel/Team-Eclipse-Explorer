using DG.Tweening;
using System.Collections;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class Level03 : MonoBehaviour
{
    public GameObject stand, run, rocket, corredor, runCorredor, standCorredoor, playerCorredor;
    public Transform endpoos, endCorredorPos;
    public GameObject Question, moon;
    public TMP_Text angleText;

    public GameObject game, oldman, solvePuzzle, launchRocket;

    public GameObject leftDoor, rightDoor;

    public Slider slider;

    private void Start()
    {
        StartCoroutine(StartRun());
    }

    IEnumerator StartRun()
    {
        yield return new WaitForSeconds(1.5f);
        stand.SetActive(false);
        run.SetActive(true);

        run.transform.DOMove(endpoos.position, 1).OnComplete(() =>
        {
            rocket.SetActive(false);
            corredor.SetActive(true);
            standCorredoor.SetActive(false);
            runCorredor.SetActive(true);
            playerCorredor.transform.DOMove(endCorredorPos.position, 4).OnComplete(() =>
            {
                runCorredor.SetActive(false);
                standCorredoor.SetActive(true);
                StartCoroutine(StartQuestion());
            });
        });
    }

    IEnumerator StartQuestion()
    {
        yield return new WaitForSeconds(.5f);
        Question.SetActive(true);
    }

    /* private void Update()
     {
         float angle = slider.value;
         int a = (int)angle;
         angleText.text = a.ToString();
         moon.transform.rotation = Quaternion.Euler(0, 0, angle);
     }*/

    public void SolvePuzzzle()
    {
        solvePuzzle.SetActive(true);
    }

    public void EnterRoom()
    {
        leftDoor.transform.DOMoveX(-35, 5);
        rightDoor.transform.DOMoveX(-28, 5);
        StartCoroutine(Launch());
    }

    IEnumerator Launch()
    {
        yield return new WaitForSeconds(3);
        launchRocket.SetActive(true);
    }
}
