using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //variable for power of speed.
    public float mvtSpeed;

    //Variable for speed in a direction x or y.
    float speedX, speedY;

    //Reference to our rigid body for the player. 
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //finding the component details and storing them in variable rb.
        //this will allow us to edit rb's values and essentially move the player.
        rb = GetComponent<Rigidbody2D>();
    }

    
    

    // Update is called once per frame

    void Update()
    {
        //making speedX get the horizontal and multiplying it by our mvt speed 
        //the max the horizontal value can be is 1 and not moving is 0.
        //doing Input.GetAxis will make it so the change in speed is not instant.
        speedX = Input.GetAxisRaw("Horizontal") * mvtSpeed;
        //doing same for y
        speedY = Input.GetAxisRaw("Vertical") * mvtSpeed;
        
        //changing our rigidbodys velocity to the new value (a vector2) which takes an x and a y value.
        rb.velocity = new Vector2(speedX, speedY);


    }
}
