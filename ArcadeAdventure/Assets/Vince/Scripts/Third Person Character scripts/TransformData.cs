using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TransformData : ScriptableObject
{
    public Vector3 value;

    public Vector3 ObjTransform
    {
        get { return value; }
        set
        {
            this.value = value;
        }
    }
}
