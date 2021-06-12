using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Collider2D doorCollider;
    public Color newColor;

    void Start()
    {
        spriteRenderer.color = newColor;
        if (doorCollider.enabled)
            doorCollider.enabled = !doorCollider.enabled;
    }

}
