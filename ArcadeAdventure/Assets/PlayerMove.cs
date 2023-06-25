using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float jumpPower;
    private float horizontal;
    [SerializeField] private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            horizontal = -1;
        } else if (Input.GetKey(KeyCode.D)) {
            horizontal = 1;
        } else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
            horizontal = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }
}
