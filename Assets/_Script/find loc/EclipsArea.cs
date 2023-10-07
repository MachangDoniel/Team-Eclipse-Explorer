
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EclipsArea : MonoBehaviour
{
    public GameObject eclipsArea,Location;
    Vector2 eclipsPos, locPos, sunPos;
    public float solveRadious = 5;

    bool reloc = false;
    Camera cam;

    public GameObject Sun, Moon;
    public Vector2 minClamp, maxClamp;

    public GameObject ResultWindow;


    private void Start()
    {
        eclipsPos = eclipsArea.transform.position;
        locPos = Location.transform.position;
        sunPos = Sun.transform.position;

        cam = Camera.main;  
    }
    private void OnMouseDown()
    {
 
        reloc = true;
    }

    private void OnMouseUp()
    {
        
    }
    private void OnMouseExit()
    {
        reloc = false;
    }

    private void Update()
    {

        if(Input.GetMouseButton(0) && reloc) 
        {
            Vector3 loc = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.z)) * -1;
            loc = new Vector3(loc.x, loc.y + 2, 0);
            eclipsArea.transform.position = loc;
            eclipsPos = loc;
        }
        _Distance();
    }

    void _Distance()
    {
       if(Vector2.Distance(Location.transform.position, eclipsPos) < solveRadious)
       {
            Moon.transform.position = sunPos;
            ResultWindow.SetActive (true);
       }
       else
       {
            float x = eclipsPos.x - Location.transform.position.x;
            float y =eclipsPos.y - Location.transform.position.y;
            float clampedX = Mathf.Clamp(sunPos.x + x, minClamp.x, maxClamp.x);
            float clampedY = Mathf.Clamp(sunPos.y + y, minClamp.y, maxClamp.y);

            Moon.transform.position = new Vector2(clampedX, clampedY);
        }

        
      

        //print(LocatonLoc + " " + EclipsAre);
    }


    void Check()
    {

    }
}
