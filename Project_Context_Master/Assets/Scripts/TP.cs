using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{

    public GameObject[] tp;
    public int tp2;

    // Start is called before the first frame update
    void Start()
    {
        tp2 = tp.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (tp.Length > tp2)
        {
            Debug.Log("bigger");
            tp2++;
        }
        else if (tp.Length < tp2)
        {
            tp2 = tp.Length;
            Debug.Log("smaller");
        }


    }
}
