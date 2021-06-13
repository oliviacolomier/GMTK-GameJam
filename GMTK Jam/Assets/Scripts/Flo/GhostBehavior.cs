using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBehavior : MonoBehaviour
{
    public float MovementSpeed = 1;
    private bool canMove;

    
   

    public bool CanMove
    {
        get 
        {
            return canMove;
        }
        set
        {
            canMove = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Blue";
        canMove = true;



        GameObject body = GameObject.FindGameObjectWithTag("Yellow");
        Physics2D.IgnoreCollision(body.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            var movement = Input.GetAxis("Horizontal");
            var verticalMovement = Input.GetAxis("Vertical");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
            transform.position += new Vector3(0,verticalMovement,0) * Time.deltaTime * MovementSpeed;
          
        }
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider.tag == gameObject.tag)
           other.collider.enabled = false;

       

    }
}
