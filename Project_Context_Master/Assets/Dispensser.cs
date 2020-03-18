using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispensser : MonoBehaviour
{
    public float bulletSpeed, spawnOffset;
    public float currentTime, minWaitTime, maxWaitTime;
    public int TimeActive = 3;
    public GameObject barrel;
    public GameObject Projectile;


    void Start()
    {
        currentTime = Random.Range(minWaitTime, maxWaitTime);
    }


    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            StartCoroutine(TrapActive());
            currentTime = Random.Range(minWaitTime, maxWaitTime);
        }
    }

    IEnumerator TrapActive()
    {
        TrapOn();
        yield return new WaitForSeconds(TimeActive);
    }

    void TrapOn()
    {
        var newobject = Instantiate(Projectile, barrel.transform.position + (barrel.transform.up * spawnOffset), barrel.transform.rotation);
        newobject.GetComponent<Rigidbody2D>().AddForce(newobject.transform.up * bulletSpeed);
    }
}
