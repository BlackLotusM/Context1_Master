using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpikeTrap : MonoBehaviour
{
    [SerializeField]
    private float currentTime, minWaitTime, maxWaitTime;
    [SerializeField]
    private int spikesOut = 3;

    public SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = spriteRenderer.GetComponent<SpriteRenderer>();
        currentTime = Random.Range(minWaitTime, maxWaitTime);

    }


    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            StartCoroutine(Spikes());
        }
    }

    IEnumerator Spikes()
    {
        SpikeOut();
        yield return new WaitForSeconds(spikesOut);
        SpikeIn();
    }

    void SpikeOut()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.red;
        }
        Debug.Log("Get shanked fool");

    }

    void SpikeIn()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.green;
        }
        spriteRenderer.color = Color.green;
        Debug.Log("Ait ill get u next time");
        currentTime = Random.Range(minWaitTime, maxWaitTime);
    }
}



