using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourMovement2 : MonoBehaviour
{

    public float speed = 10.0f;
    public float jumpSpeed = 10.0f;

     public bool isRunning = false;
     public bool isJumping = false;

    private float X;
    private bool canJump;
    private bool inFluid = false;

    public bool inTutorial = false;

    void Update()
    {
        Move();

        if (inFluid == true)
        {
            Physics.gravity = new Vector3(0, -4.905f, 0);

            speed = speed / 2;

            jumpSpeed = jumpSpeed / 2;
        }

        if (inFluid == false)
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);

            speed = 10f;

            jumpSpeed = 10f;
        }
    }

    void Move()
    {
        if (inTutorial == false)
        {
            X = Input.GetAxis("Horizontal");
        }

        if (inTutorial == true)
        {
            X = Input.GetAxis("FalseHori");
        }

        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(X * speed, gameObject.GetComponent<Rigidbody>().velocity.y, 0);

        if (inTutorial == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
            {

                GetComponent<Rigidbody>().velocity = Vector3.up * jumpSpeed;
                canJump = false;
                isJumping = true;

            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                isRunning = true;
            }

            else if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                isRunning = true;
            }

            else
            {
                isRunning = false;
            }
        }

        if (inTutorial == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
            {

                GetComponent<Rigidbody>().velocity = Vector3.up * jumpSpeed;
                canJump = false;
                isJumping = true;

            }

            if (Input.GetKey(KeyCode.L))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                isRunning = true;
            }

            else if (Input.GetKey(KeyCode.J))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                isRunning = true;
            }

            else
            {
                isRunning = false;
            }
        }

    }

    public void OnTriggerEnter(Collider collider)
    {

        if (collider.CompareTag("Fluid"))
        {
            inFluid = true;
        }

        if (collider.CompareTag("Ground"))
        {
            canJump = true;
            isJumping = false;
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Fluid"))
        {
            inFluid = false;
        }
    }

    public void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("FakeMove"))
        {
            inTutorial = true;
        }
    }

    
}
