using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewsCardProperty : MonoBehaviour, IPointerClickHandler
{
    string title,url,date;
    public TMP_Text titleText, dateText;

    public void SetProperty(string title,string date,string url)
    {
        print(title);
        this .title = title;
        this .url = url;
        this .date = date;

        titleText.text = title;
        dateText.text = date;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print (titleText.text);
        Application.OpenURL(url);
    }


}
