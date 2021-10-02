using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovement : MonoBehaviour
{
   public float moveSpeed = 8f;
    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=0;
       /** if(movement.y==0){

            movement.y=-1;
        }**/
        
    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position+movement*moveSpeed*Time.fixedDeltaTime);

    }
}
