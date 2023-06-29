using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DMovement : MonoBehaviour
{
    [SerializeField] FloatReference movementSpeed;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void MoveRight()
    {
        transform.position += -transform.right * movementSpeed.value * Time.deltaTime;
    }

    public void MoveLeft()
    {
        transform.position += transform.right * movementSpeed.value * Time.deltaTime;
    }
}
