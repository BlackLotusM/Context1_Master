using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPScript : MonoBehaviour
{
    public GameObject Connected;
    Salamander test;

    private void Start()
    {
        test = new Salamander();
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.name == "Salamander")
        {
            if(test.usingPwr == true)
            {
                Debug.Log("OWO");
                collision.gameObject.transform.position = Connected.transform.position;
            }
        }
    }
}
