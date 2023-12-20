using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCameraFace : MonoBehaviour
{
    private Camera mainCamera; //refrence to our camera

    private void Start()
    {
        mainCamera = Camera.main; //we set our camera to be our main camera
    }

    private void LateUpdate()
    {
        // we make the canvas face the camera's direction
        transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward, mainCamera.transform.rotation * Vector3.up);
    }
}
