using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Characteristics")]
    public float speed;
    
    void Start()
    {
        Destroy(gameObject, 5f);
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
