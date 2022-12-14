using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator animator;
    public float isFast;
    public float horizontal;
    //public bool rightSide;


    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        animator.SetFloat("Horizontal", horizontal);
      
        //animator.SetBool("RightSide", rightSide);
    }
}
