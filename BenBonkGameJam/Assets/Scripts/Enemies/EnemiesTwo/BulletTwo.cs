using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTwo : MonoBehaviour
{
    [Header("Characteristics")]
    public float Seconds;
    public float speed;

    private Transform player;
    private Vector3 direction;
    private Vector3 lastpos;
    private Rigidbody rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        Destroy(gameObject, Seconds);

        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //transform.Translate(direction * (30f * Time.deltaTime));
        lastpos = player.position;
        direction = (lastpos - transform.position).normalized;
        rb.AddForce(direction * speed);

    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
