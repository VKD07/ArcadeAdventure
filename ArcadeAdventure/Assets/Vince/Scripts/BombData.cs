using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BombData : ScriptableObject
{
    public float bombCountdown;
    public float bombRange = 2f;
    public LayerMask layerAffected;
}

