using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 1;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        // Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        // rb.AddForce(movement * speed);
        animator.SetFloat("Speed", Mathf.Abs(movementX * speed));
        rb.velocity = new Vector3(movementX * speed, rb.velocity.y, movementY * speed);
    }
}