using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMove : MonoBehaviour
{

    Rigidbody2D rgbd2d;
    [HideInInspector]
    public Vector3 movementVector;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    //public bool lastSide;

    [SerializeField] float speed = 3f;
    //bool rightSide;
 
    
    Animate animate;

    private void Awake()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
        animate = GetComponent<Animate>();
    }
 

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");
        //rightSide = Input.GetAxisRaw("RightSide");

        if (movementVector.x != 0)
        {
            lastHorizontalVector = movementVector.x;
            //lastSide = rightSide;
        }
        if (movementVector.y != 0)
        {
            lastVerticalVector = movementVector.y;
            //lastSide = rightSide;
        }

        animate.horizontal = movementVector.x;

        movementVector *= speed;

        rgbd2d.velocity = movementVector;
       
    }
}
