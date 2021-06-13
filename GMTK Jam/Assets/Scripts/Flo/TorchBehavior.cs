using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchBehavior : MonoBehaviour
{
    public SpriteRenderer torchModel;
    public Collider2D torchCollider;

    public Sprite whiteTorch;
    public Sprite yellowTorch;
    public Sprite blueTorch;
    public Sprite greenTorch;
    void Start()
    {
        if (gameObject.tag == "Untagged")
            gameObject.tag = "White";
        else
            changeColor(gameObject.tag);
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
            changeColor(other.tag);
            torchCollider.isTrigger = false;    
        } else if (gameObject.tag != other.tag)
            torchCollider.isTrigger = false;
    }

    void changeColor(string currentTag)
    {
    if (currentTag == "Blue")
        torchModel.sprite = blueTorch;
    else if (currentTag == "Yellow")
        torchModel.sprite = yellowTorch;
    else if (currentTag == "Green")
        torchModel.sprite = greenTorch;
    }
}


