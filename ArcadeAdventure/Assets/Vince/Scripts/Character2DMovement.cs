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
        SetDirection(-transform.right);
    }

    public void MoveLeft()
    {
        SetDirection(transform.right);
    }

    public void MoveUp()
    {
        SetDirection(transform.up);
    }

    public void MoveDown()
    {
        SetDirection(-transform.up);
    }

    void SetDirection(Vector3 direction)
    {
        transform.position += direction * movementSpeed.value * Time.deltaTime;
    }
}
