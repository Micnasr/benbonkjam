using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourMovement2 : MonoBehaviour
{

    public float speed = 10.0f;
    public float jumpSpeed = 10.0f;

    public float X;

    public bool canJump;
    public bool inFluid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Move();

        if (inFluid == true)
        {
            Physics.gravity = new Vector3(0, -4.905f, 0);

            speed = 5.0f;

            jumpSpeed = 5.0f;
        }

        if (inFluid == false)
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);

            speed = 10.0f;

            jumpSpeed = 10.0f;
        }

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
    }

    void Jump()
    {
        print(0);
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed * 35);

    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Ground"))
        {
            canJump = true;
            print(canJump);

        }

        if(collider.CompareTag("Fluid"))
        {
            inFluid = true;
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if(collider.CompareTag("Fluid"))
        {
            inFluid = false;
        }
    }
}
