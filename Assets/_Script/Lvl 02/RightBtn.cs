using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBtn : MonoBehaviour
{
    public CirculerMovement circulerMovement;

    private void OnMouseDown()
    {
        circulerMovement.right = true;
    }

    private void OnMouseUp()
    {
        circulerMovement.right = false;
    }
}
