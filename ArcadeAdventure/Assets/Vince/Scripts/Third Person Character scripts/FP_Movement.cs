using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_Movement : MonoBehaviour
{
    [SerializeField] PlayerControlsData playerControls;
    [SerializeField] float movementSpeed;
    [SerializeField] float dragValue = 5f;
    [SerializeField] Transform direction;
    Vector3 moveDirection;
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
        moveDirection = direction.forward * playerControls.VerticalAxis + direction.right * playerControls.HorizontalAxis;
        rb.velocity = moveDirection * movementSpeed;
        rb.drag = dragValue;
    }
}
