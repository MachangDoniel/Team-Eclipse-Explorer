using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreLevelLession : MonoBehaviour
{
    public float slideX;
    void Start()
    {
        Motions.Instance.OldManSlide(slideX);        
    }


    void Update()
    {
        
    }
}
