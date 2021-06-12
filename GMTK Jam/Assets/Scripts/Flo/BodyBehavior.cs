using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBehavior : MonoBehaviour
{
    public float MovementSpeed = 1;
    public Rigidbody2D rigidbody2d;
    public float jumpVelocity = 10f;
    private bool isJumping;
    private bool canJump;
    public bool CanJump
    {
        get 
        {
            return canJump;
        }
        set
        {
            canJump = value;
        }
    }
    void Start()
    {
        gameObject.tag = "Green";
    }

    // Update is called once per frame
    void Update()
    {
         var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && canJump)
        {
          
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            isJumping = true;

        }

        if (gameObject.tag == "Yellow")
            gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        else
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;

    }

    void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.CompareTag("Ground"))
            {
                isJumping = false;
            }
            if(other.collider.tag == gameObject.tag)
                other.collider.enabled = false;
        }
}
