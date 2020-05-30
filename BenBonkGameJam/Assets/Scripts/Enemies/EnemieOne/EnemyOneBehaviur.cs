using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class EnemyOneBehaviur : MonoBehaviour
{
    [Header("Configuration")]
    public Transform firePoint;

    [Header("Prefab and Delay")]
    public GameObject Bullet;
    public float Seconds;


    private bool canShoot = true;
    void Update()
    {
        if(canShoot == true)
        {
            Instantiate(Bullet, firePoint.position, firePoint.rotation);
            canShoot = false;
            StartCoroutine(wait());
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(Seconds);
        canShoot = true;
    }
}
