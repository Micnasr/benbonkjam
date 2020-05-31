using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlataform : MonoBehaviour
{
    public float speed;
    public float maxX;
    public float minX;
    private bool moveRight = true;

    
    void Update()
    {
        if (transform.position.x > maxX)
        {
            moveRight = false;
        }

        if (transform.position.x < minX)
        {
            moveRight = true;
        }

        if (moveRight == true)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        
        else
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }

    }
}
