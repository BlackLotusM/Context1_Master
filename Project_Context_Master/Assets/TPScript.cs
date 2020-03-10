using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPScript : MonoBehaviour
{
    public Collider2D coll;

    // Use this for initialization
    void Start()
    {
        //Check if the isTrigger option on th Collider2D is set to true or false
        if (coll.isTrigger)
        {
            Debug.Log("This Collider2D can be triggered");
        }
        else if (!coll.isTrigger)
        {
            Debug.Log("This Collider2D cannot be triggered");
        }
    }
}
