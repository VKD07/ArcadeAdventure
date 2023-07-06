using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            myLight.enabled = !myLight.enabled;

        }
    }
}
