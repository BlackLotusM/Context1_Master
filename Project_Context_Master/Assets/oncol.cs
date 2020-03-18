using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name = collision.gameObject.name;
        Debug.Log(name + "Hit the pit");
    }
}
