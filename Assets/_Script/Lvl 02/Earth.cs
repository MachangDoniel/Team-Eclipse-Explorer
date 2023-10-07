using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public CheckEclips checkEclips;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("earthCollider"))
        {
            checkEclips.collided = true;
        }
    }
}
