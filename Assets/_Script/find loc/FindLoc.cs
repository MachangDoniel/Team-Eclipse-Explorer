using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindLoc : MonoBehaviour
{
    public Slider slider;
    public GameObject earthImg;
   
    private void Update()
    {
        earthImg.transform.position =new Vector3( slider.value, earthImg.transform.position.y, earthImg.transform.position.z);
    }

}
