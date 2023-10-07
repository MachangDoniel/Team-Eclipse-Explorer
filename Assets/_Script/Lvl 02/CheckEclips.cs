using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEclips : MonoBehaviour
{
    public Transform earth, sun, moon;
    Vector2 sunEarth, earthMoon;
    public GameObject ResultWindow, buttons, _earth, shadow;

    public Vector2 moonAngleRange, earthDistanceRange;

    float angle,distance;
    public bool collided = false;
    void Update()
    {
        sunEarth = sun.position - earth.position;
        earthMoon = earth.position - moon.position;

        angle = Vector2.Angle(sunEarth, earthMoon);
        distance = Vector2.Distance(earth.position, sun.position);
        //print(angle);
       // print(Vector2.Distance(earth.position,sun.position));

        if (angle >= moonAngleRange.x && angle <= moonAngleRange.y)
        {
            /*if(distance >= earthDistanceRange.x && distance <= earthDistanceRange.y)
            {
                print("yes");

                ResultWindow.SetActive(true);
                buttons.SetActive(false);
                earth.GetComponent<CirculerMovement>().angulerSpeed = 0;
                moon.GetComponent<CirculerMovement>().angulerSpeed = 0;
            }
            else
            {
                ResultWindow.SetActive(false);
            }*/
            if(collided)
            {
                ResultWindow.SetActive(true);
                shadow.SetActive(true);
                buttons.SetActive(false);
                earth.GetComponent<CirculerMovement>().angulerSpeed = 0;
                moon.GetComponent<CirculerMovement>().angulerSpeed = 0;
            }
        }
    }
}
