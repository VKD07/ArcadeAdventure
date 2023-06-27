using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movent3DCharacter : MonoBehaviour
{
    [SerializeField] PlayerControlsData playerControls;
    [SerializeField] FloatReference movementSpeed;
    [SerializeField] FloatReference rotationSpeed;
    [SerializeField] FloatReference characterVelocity;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 movementDirection = new Vector3(-playerControls.HorizontalAxis, 0f, -playerControls.VerticalAxis);
        movementDirection.Normalize();

        rb.velocity = movementDirection * movementSpeed.value;
        //transform.Translate(movementDirection * movementSpeed.value * Time.deltaTime);
        characterVelocity.value = movementDirection.magnitude;
        MovementDirection(movementDirection);
    }

    private void MovementDirection(Vector3 movementDirection)
    {
        if (movementDirection != Vector3.zero)
        {
            transform.forward = movementDirection;
        }
    }
}
