using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraZoom : MonoBehaviour
{
    public Camera _camera;
    [SerializeField]
    public Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        _camera.fieldOfView = slider.value;
    }

}
