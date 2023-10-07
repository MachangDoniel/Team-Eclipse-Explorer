using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionAndAnswer : MonoBehaviour
{

    public List<Question> questions;
    public GameObject[] options;
    int currentQuestion;
    public ImageList imageList;

    public GameObject nextWidow;

    private void Start()
    {
        currentQuestion = -1;
        GenerateQuestion();
    }

    public void Correct()
    {
        
        GenerateQuestion();
        imageList.Change(currentQuestion);
    }

    void SetAnswer()
    {
        for (int i=0; i < options.Length ; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = questions[currentQuestion].answers[i].ToString();

            if (questions[currentQuestion].correctAns == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;

            }
        }
        imageList.Change(currentQuestion);

    }


    void GenerateQuestion()
    {
        //Image img = questions[currentQuestion].question.GetComponent<Image>();
        currentQuestion ++;
        print(currentQuestion);
        if(currentQuestion >= questions.Count)
        {
            nextWidow.SetActive(true);
            return ;
        }
        SetAnswer();

    }

}
