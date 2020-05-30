using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieTwoBehaviur : MonoBehaviour
{
    [Header("Configuration")]
    public Transform firePoint;
    public GameObject Bullet;
    
    [Header("Characteristics")]
    public float Seconds;
    public float Range;

    private GameObject player;
    private bool canShoot = true;
            
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < Range && canShoot == true)
        {
            //Player in range of the enemy
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
