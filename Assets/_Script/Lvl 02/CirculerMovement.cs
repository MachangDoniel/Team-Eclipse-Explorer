using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirculerMovement : MonoBehaviour
{
    public Transform rotationCenter;
    public float rotationRadious = 2f, angulerSpeed = 2f;

    float posX, posY, angle = 0;

    public bool left,right;

    // Update is called once per frame
    void Update()
    {
        if(left)
        {
            Move();
            angle = angle - Time.deltaTime * angulerSpeed;
        }
        if(right)
        {
            Move();
            angle = angle + Time.deltaTime * angulerSpeed;
        }
        
        

        if(angle >= 360 || angle <= -360)
        {
            angle = 0;
        }
    }

    void Move()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadious;
        posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadious / 1.5f;
        transform.position = new Vector2(posX, posY);
    }
}
