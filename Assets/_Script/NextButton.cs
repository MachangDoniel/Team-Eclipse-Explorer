using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public List<GameObject> items;
    public GameObject itemAtTheEnd;
    int index = 0;

    public GameObject objectToHide, objectToShow;

    public void AddIndex()
    {
        index++;
        if (index >= items.Count)
        {
            AtTheEnd();
        }
        else
        {
            Show();
        }
    }

    void Show()
    {
        foreach (var item in items)
        {
            item.gameObject.SetActive(false);
        }
        items[index].gameObject.SetActive(true);
    }

    void AtTheEnd()
    {
        print("end");
        if (objectToShow) objectToShow.SetActive(true);

        if (objectToHide) objectToHide.SetActive(false);
    }
}
