using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    public static ShakeCamera Instance;
    [SerializeField] string animationParemeter = "ShakeCamera";
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Awake()
    {
        Instance = this;
    }

    public void TriggerCameraShake()
    {
        animator.SetTrigger(animationParemeter);
    }
}
