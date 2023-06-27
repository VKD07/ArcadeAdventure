using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activate3D : MonoBehaviour
{
    [SerializeField] PlayerControlsData playerControlsData;
    [SerializeField] UnityEvent Enable3D;
    [SerializeField] UnityEvent Disable3D;
    bool activated;

    // Update is called once per frame
    void Update()
    {
        Enable();
    }

    private void Enable()
    {
        if (Input.GetKeyDown(playerControlsData.Activate3DKey) && !activated)
        {
            activated = true;
            Enable3D.Invoke();  
        }else if(Input.GetKeyDown(playerControlsData.Activate3DKey) && activated)
        {
            activated = false;
            Disable3D.Invoke();
        }

    }
}
