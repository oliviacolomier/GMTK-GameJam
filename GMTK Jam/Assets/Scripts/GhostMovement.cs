using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public float MovementSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        transform.position += new Vector3(0,verticalMovement,0) * Time.deltaTime * MovementSpeed;
    }
}
