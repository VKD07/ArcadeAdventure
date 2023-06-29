using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] TransformData cameraPos;
    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPos.ObjTransform;
    }
}
