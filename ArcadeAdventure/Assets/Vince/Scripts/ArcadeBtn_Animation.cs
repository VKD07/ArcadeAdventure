using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeBtn_Animation : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PressedAnim(bool enable)
    {
        anim.SetBool("Pressed", enable);
    }
}
