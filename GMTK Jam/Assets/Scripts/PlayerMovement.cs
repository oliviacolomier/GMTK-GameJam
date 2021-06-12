using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed = 1;
    public Rigidbody2D rigidbody2d;
    public float jumpVelocity = 10f;
    private bool isJumping;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
          
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            isJumping = true;

        }
    }

 void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

}
