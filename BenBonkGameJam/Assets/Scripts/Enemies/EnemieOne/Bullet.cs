using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Characteristics")]
    public float speed;
    public float delay;
    
    void Start()
    {
        Destroy(gameObject, delay);
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
