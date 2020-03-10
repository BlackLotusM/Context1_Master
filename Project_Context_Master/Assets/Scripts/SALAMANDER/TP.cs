using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    Salamander test;
    public GameObject otherTel;

    private void Start()
    {
       //BoxCollider2D test =  this.gameObject.GetComponent<BoxCollider2D>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Salamander"))
        {
            test = collision.gameObject.GetComponent<Salamander>();
            if (test.usingPwr == true)
            {
                collision.gameObject.transform.position = new Vector3(otherTel.transform.position.x, otherTel.transform.position.y, collision.transform.position.z);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Salamander"))
        {
            test = collision.gameObject.GetComponent<Salamander>();
            if (test.usingPwr == true)
            {
                collision.gameObject.transform.position = new Vector3(otherTel.transform.position.x, otherTel.transform.position.y, collision.transform.position.z);
            }
        }
    }
}
