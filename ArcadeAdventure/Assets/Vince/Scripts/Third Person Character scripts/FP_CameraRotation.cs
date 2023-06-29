using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_CameraRotation : MonoBehaviour
{
    [SerializeField] float mouseXSensitivity;
    [SerializeField] float mouseYSensitivity;
    [SerializeField] Transform direction;
    [SerializeField] Transform cameraPos;
    [SerializeField] TransformData cameraPosData; 

    float xRotation;
    float yRotation;
    void Start()
    {
        MouseLock();
    }

    // Update is called once per frame
    void Update()
    {
        MouseRotation();
        SetCameraPosition();
    }

    private void MouseLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void MouseRotation()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseXSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseYSensitivity * Time.deltaTime;
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        direction.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }

    private void SetCameraPosition()
    {
        cameraPosData.ObjTransform = cameraPos.transform.position;
    }
}
