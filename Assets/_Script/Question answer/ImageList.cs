using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageList : MonoBehaviour
{
    public GameObject[] images;
    
   

    public void Change(int index)
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].SetActive(false);
        }
        if(index < images.Length)
        {
            images[index].SetActive(true);
        }
       
    }

}
