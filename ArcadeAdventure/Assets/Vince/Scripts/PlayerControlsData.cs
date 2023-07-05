using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerControlsData : ScriptableObject
{
    [SerializeField] KeyCode activate3DKey;
    [SerializeField] KeyCode bombKey;
    public float HorizontalAxis
    {
        get
        {
            return Input.GetAxis("Horizontal");
        }
    }

    public float VerticalAxis
    {
        get
        {
            return Input.GetAxis("Vertical");
        }
    }

    public KeyCode Activate3DKey
    {
        get { return activate3DKey; }
    }

    public KeyCode BombKey => bombKey;
}
