using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject nextPrevBtn;

    public GameObject windowToShowAtEnd, windowToHide;

    int index;
    void Start()
    {
        index = 0;
        textComponent.text = string.Empty;
        StartDialogue();
    }


    void StartDialogue()
    {
        
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (var c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        if(nextPrevBtn) nextPrevBtn.SetActive(true);

    }

    public void NextLine()
    {
        if(index < lines.Length-1)
        {
            index++;
            textComponent.text = string.Empty;
            if (nextPrevBtn) nextPrevBtn.SetActive(false);
            StartDialogue();
        }

        else
        {
            if(windowToShowAtEnd)
            windowToShowAtEnd.SetActive(true);
            if(windowToHide)
            windowToHide.SetActive(false);
        }
    }
    public void PrevLine()
    {
        if( index >= 0)
        {
            index--;
            textComponent.text = string.Empty;
            if (nextPrevBtn) nextPrevBtn.SetActive(false);
            StartDialogue();
        }
    }
}
