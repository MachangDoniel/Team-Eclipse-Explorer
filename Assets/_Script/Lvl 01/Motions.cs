using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Motions : MonoBehaviour
{
    public static Motions Instance;

    public Transform OldMan, PlayerRunPos, RocketPos;

    public GameObject PlayerStand, _PlayerRun, robotUi, enterRocketUi;

    public int level;

    private void Start()
    {
        if(Instance != null && Instance!= this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        if(level == 1)
        {
            PlayerRunStand(PlayerRunPos.position);
        }

    }

    public void OldManSlide(float positionX)
    {
        OldMan.DOMoveX(positionX, 3);
    }

    public void PlayerRunStand(Vector2 positon)
    {
        StartCoroutine(HidePlayer(positon));
    }

    IEnumerator HidePlayer(Vector2 a)
    {
        yield return new WaitForSeconds(1.5f);
        PlayerStand.gameObject.SetActive(false);
        _PlayerRun.gameObject.SetActive(true);
        PlayerStand.transform.DOMove(a, 5);
        _PlayerRun.transform.DOMove(a, 5).OnComplete(() =>
        {
            PlayerStand.gameObject.SetActive(true);
            _PlayerRun.gameObject.SetActive(false);
            StartCoroutine(WaitForQues());
        });
        
    }

    IEnumerator WaitForQues()
    {
        yield return new WaitForSeconds(1);
        robotUi.gameObject.SetActive(true);
    }


    public void PlayerRunRocket()
    {
        StartCoroutine(HidePlayerRocket(RocketPos.position));
    }

    IEnumerator HidePlayerRocket(Vector2 a)
    {
        yield return new WaitForSeconds(.5f);
        PlayerStand.gameObject.SetActive(false);
        _PlayerRun.gameObject.SetActive(true);
        PlayerStand.transform.DOMove(a, 5);
        _PlayerRun.transform.DOMove(a, 5).OnComplete(() =>
        {
            PlayerStand.gameObject.SetActive(true);
            _PlayerRun.gameObject.SetActive(false);
            StartCoroutine(WaitFoRocket());
        });

    }

    IEnumerator WaitFoRocket()
    {
        yield return new WaitForSeconds(1);
        enterRocketUi.SetActive(true);
    }


}
