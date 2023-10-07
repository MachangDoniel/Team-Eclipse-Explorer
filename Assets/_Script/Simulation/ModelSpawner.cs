using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSpawner : MonoBehaviour
{
    public GameObject[] models;
    public Transform spawnPoint;
    private void Start()
    {
        GameObject go= Instantiate(models[ModelSelector.Instance.modelIndex], spawnPoint.position, Quaternion.identity);
        go.AddComponent<Drag>();
        //ModelSelector.Instance.modelIndex
    }
}
