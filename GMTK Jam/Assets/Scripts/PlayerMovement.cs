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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        //var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        // transform.position += new Vector3(0,verticalMovement,0) * Time.deltaTime * MovementSpeed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }
}
