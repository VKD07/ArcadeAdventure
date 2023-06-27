using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatReference : ScriptableObject
{
   public float value;

    public void SetVelocityValue(float speed)
    {
        value = speed;
    }
}
