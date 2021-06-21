using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCol : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(object1.GetComponent<Collider2D>(), object2.GetComponent<Collider2D>());
    }
}
