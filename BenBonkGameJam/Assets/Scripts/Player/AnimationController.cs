using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [Header("Configuration")]
    public BehaviourMovement2 movement;
    Animator animator;
     

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (movement.isRunning == true)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (movement.isJumping == true)
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);
        }
    }
}

