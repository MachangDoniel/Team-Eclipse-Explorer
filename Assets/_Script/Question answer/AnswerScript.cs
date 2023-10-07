using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public GameObject correct, wrong;
    public QuestionAndAnswer questionAndAnswer;

    public void Answer()
    {
        if(isCorrect)
        {
            print("Corrrect");
            questionAndAnswer.Correct();
            correct.SetActive(true);
            wrong.SetActive(false);

        }
        else
        {
            print("Wrong");
            questionAndAnswer.Correct();
            correct.SetActive(false);
            wrong.SetActive(true);
        }
    }

    
}
