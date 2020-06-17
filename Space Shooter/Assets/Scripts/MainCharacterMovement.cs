using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
public float speed;
public float maxSpeed;
public float breakSpeed;
private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.D))
         {
            rb.transform.position += Vector3.right * speed * Time.deltaTime;
            
         }
         else if(Input.GetKey(KeyCode.A))
         {
            rb.transform.position += Vector3.right * -speed * Time.deltaTime;
             
         }
        
        
        
        /*
        //Store the current horizontal input in the float moveHorizontal.
        float xInput = Input.GetAxis ("Horizontal");
        
        if(-0.3 <= xInput && xInput <= 0.3) {
                rb.velocity = rb.velocity*breakSpeed;
            }
        else {
            if(rb.velocity.magnitude < maxSpeed) {
            float xForce = xInput * speed * Time.deltaTime;
            Vector2 movement = new Vector2 (xForce, 0);
            rb.AddForce(movement);
            }
        } */
    }
}