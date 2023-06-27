using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character3DAnimation : MonoBehaviour
{
    [SerializeField] FloatReference velocity;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        WalkAnimation();
    }
    private void WalkAnimation()
    {
        animator.SetFloat("Velocity", velocity.value);
    }
    public void ActivateLegs(bool enable)
    {
        animator.SetBool("Legs", enable);
    }
}
