using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    // Start is called before the first frame update

    public Image barImage;
    public float owo;
    public bool overuse;
    public Image test;

    private void Start()
    {
        //Image test = barImage.GetComponent<Image>();
    }
    private void Update()
    {
        test = barImage.GetComponent<Image>();
        if (overuse == true)
        {
            test.color = Color.red;
        }
        else if(overuse == false)
        {
            test.color = Color.blue;
        }
        
        if(owo > 1)
        {
            owo = 1;
        }
        if (owo < 0)
        {
            owo = 0;
        }

        barImage.fillAmount = owo;
    }
}
