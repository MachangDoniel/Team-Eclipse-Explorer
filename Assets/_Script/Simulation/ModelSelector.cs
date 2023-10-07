using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelector : MonoBehaviour
{
    public static ModelSelector Instance { get; private set; }

    [HideInInspector] public int modelIndex;

    private void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        
    }

    public void SetIndex(int a)
    {
        modelIndex = a;
        
    }
}
