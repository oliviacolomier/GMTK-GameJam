using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchBehavior : MonoBehaviour
{
    public SpriteRenderer torchModel;
    public Collider2D torchCollider;
    void Start()
    {
        if (gameObject.tag == "Untagged")
            gameObject.tag = "White";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionStay2D(Collision2D other) {
        Debug.Log(other.collider.name + " " + other.collider.tag);
        if(other.collider.tag == gameObject.tag)
            torchCollider.isTrigger = true;
    }

    // void OnCollisionExit2D(Collision2D other) {
    //     Debug.Log(other.collider.name + " " + other.collider.tag);
    //     if(other.collider.tag == gameObject.tag)
    //         torchCollider.enabled = true
    // }


    private void OnTriggerEnter2D(Collider2D other) {
        if(gameObject.tag == "White")
        {
            gameObject.tag = other.tag;
            if (other.tag == "Blue")
                torchModel.color = Color.blue;
            else if (other.tag == "Yellow")
                torchModel.color = Color.yellow;
            else if (other.tag == "Green")
                torchModel.color = Color.green;
            torchCollider.isTrigger = false;    
        } else if (gameObject.tag != other.tag)
            torchCollider.isTrigger = false;
    }
}
