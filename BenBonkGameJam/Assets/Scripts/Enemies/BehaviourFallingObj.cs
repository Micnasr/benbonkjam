using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourFallingObj : MonoBehaviour
{

    public bool fall;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fall == true)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            fall = true;
        }
    }
}
