using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01 : MonoBehaviour
{
    public Transform playerPos; 
    void Start()
    {
        Motions.Instance.PlayerRunStand(playerPos.position);
    }

 
}
