using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrollerMovement : MonoBehaviour
{
    [SerializeField]
    private float movespeed;

    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private bool facingRight;


    private float movedirection;

 

    
    Vector2 Pos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        
        
        movedirection = Input.GetAxis("Horizontal");

        if (movedirection > 0 && !facingRight)
        {
            flipCharacter();
        }

        else if (movedirection < 0 && facingRight)
        {
            flipCharacter();
        }

       
        rb.velocity = new Vector2(movedirection * movespeed, rb.velocity.y);
     
    }

    private void flipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
