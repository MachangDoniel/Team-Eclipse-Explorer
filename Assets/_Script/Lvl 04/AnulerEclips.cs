using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnulerEclips : MonoBehaviour
{
    public GameObject moon;

    public Slider slider;
    public GameObject resultWindow, btn;

    public Rigidbody2D rocket;

    bool bLaunche = false;


    private void Update()
    {
        moon.transform.position = new Vector2(slider.value,moon.transform.position.y );

        if(btn != null )
        {
            if (slider.value > -.9f && slider.value < .2f && moon.transform.localScale.x == .9f)
            {
                //result.SetActive(true);
                btn.SetActive(false);
            }
            else
            {
                btn.SetActive(true);

            }
        }
       
    }

    private void FixedUpdate()
    {
        //Rocketstand.transform.rotation = Quaternion.Euler(0, 0, -(slider.value) * 10);

        if (bLaunche)
        {
            rocket.transform.localPosition = new Vector3(rocket.transform.localPosition.x, rocket.transform.localPosition.y + .06f, 0);
            resultWindow.SetActive(true);
        }
    }


    public void Launch()
    {
        bLaunche = true;
    }

    public void SetMoonSize(float size)
    {
        moon.transform.localScale = new Vector2(size,size);
    }

}
