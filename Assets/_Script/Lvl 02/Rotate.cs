using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch screenTouch = Input.GetTouch(0);

            if (screenTouch.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, -screenTouch.deltaPosition.x / 4f, 0f);
            }
        }
    }
}
