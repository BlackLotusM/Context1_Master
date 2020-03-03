using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectActive : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject t;
    void Start()
    {
        t = GetComponent<GameObject>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
    }
}
