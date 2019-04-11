using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //Reference to the rigidbody component on player character (rb)
    public Rigidbody rb;

    //Public variable you can change in unity attached to player character for speeds
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	
	// using FixedUpdate for better performance for physics based code. 
    // Using Time.deltaTime for balanced performance on all systems regardless of FPS for player.
    // Code for forward movement/speed of player character.
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

    }
}
