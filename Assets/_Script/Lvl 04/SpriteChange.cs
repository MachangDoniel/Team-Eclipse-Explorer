using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChange : MonoBehaviour
{
    public Slider slider;
    public GameObject[] moons;
    float opacity;
    int spriteNo;

    private void Start()
    {
        slider.onValueChanged.AddListener(delegate { OnSliderValueChanged(slider.value); });
    }

    public void OnSliderValueChanged(float newValue)
    {
      
        spriteNo = (int)slider.value;

        for(int i = 0;i<moons.Length;i++)
        {
            moons[i].SetActive(false);
        }
        moons[spriteNo].SetActive(true);
 
    }
}
