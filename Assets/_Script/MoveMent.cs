using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveMent : MonoBehaviour
{
    public Vector2 movePos;
    public float transitionTime, delayTime;
    public bool bLoop;
    public bool playOnEnable;

    private void OnEnable()
    {
        if (playOnEnable)
        {
            Move();
        }

    }

    public void Move()
    {
        if (bLoop)
        {
            gameObject.transform.DOLocalMove(movePos, transitionTime).SetLoops(-1, LoopType.Yoyo);
        }
        else
        {
            gameObject.transform.DOLocalMove(movePos, transitionTime).SetDelay(delayTime);
        }
    }
}
