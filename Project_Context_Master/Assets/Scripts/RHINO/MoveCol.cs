using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCol : MonoBehaviour
{

    Rigidbody2D move;

    private void Start()
    {
         move = GetComponent<Rigidbody2D>();
        move.isKinematic = true;
    }

    private void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        
        Collider2D collider = collision.collider;

        if (collider.name == "Rhino")
        {
            move.isKinematic = false;
        }
        else
        {
            move.isKinematic = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        move.isKinematic = true;
        move.velocity = Vector2.zero;
    }
}
