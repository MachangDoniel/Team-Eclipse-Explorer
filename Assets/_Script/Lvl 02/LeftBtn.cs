using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBtn : MonoBehaviour
{
    public CirculerMovement circulerMovement;

    private void OnMouseDown()
    {
        circulerMovement.left = true;
    }

    private void OnMouseUp()
    {
        circulerMovement.left = false;
    }
}
