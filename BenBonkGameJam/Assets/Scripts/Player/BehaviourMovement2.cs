﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourMovement2 : MonoBehaviour
{

    public float speed = 10.0f;
    public float jumpSpeed = 10.0f;

    public float X;

    public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }

    void Move()
    {
        X = Input.GetAxis("Horizontal");

        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(X * speed, gameObject.GetComponent<Rigidbody>().velocity.y, 0);

        if(Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            Jump();
            canJump = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }

    }

    void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed * 35);

    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
}
