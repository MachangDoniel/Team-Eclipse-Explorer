using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{

    CanvasGroup canvasGroup;
    public bool OnEnableFadeIn = false, OnEnableFadeOut = false;

    public float delayTimer;


    private void OnEnable()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (OnEnableFadeIn) FadeIn();
        if (OnEnableFadeOut) FadeOut();
    }


    bool fadeIn = false, fadeOut = false;

    private void Update()
    {
        if (fadeIn)
        {
            if (delayTimer > 0)
            {
                delayTimer -= Time.deltaTime;
            }
            else
            {
                if (canvasGroup.alpha < 1)
                {
                    canvasGroup.alpha += Time.deltaTime;
                    if (canvasGroup.alpha >= 1)
                    {
                        fadeIn = false;
                    }
                }
            }

        }

        if (delayTimer > 0)
        {
            delayTimer -= Time.deltaTime;
        }
        else
        {
            if (fadeOut)
            {
                if (canvasGroup.alpha > 0)
                {
                    canvasGroup.alpha -= Time.deltaTime * Time.deltaTime;
                    if (canvasGroup.alpha <= 0)
                    {
                        fadeOut = false;
                    }
                }
            }
        }
    }

    public void FadeIn()
    {
        canvasGroup.alpha = 0;
        fadeIn = true;
    }
    public void FadeOut()
    {
        canvasGroup.alpha = 1;
        fadeOut = true;
    }
}
