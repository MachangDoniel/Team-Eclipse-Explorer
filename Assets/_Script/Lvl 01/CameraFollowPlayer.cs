using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    Camera camera;
    public GameObject player;
    private void Start()
    {
        camera = Camera.main;   
    }
    void Update()
    {
        camera.transform.position =new Vector3 (player.transform.position.x,1,-10);
    }
}
