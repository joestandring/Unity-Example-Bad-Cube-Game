using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component named "rb"
    public Rigidbody rb;

    // Creating variables in the editor also makes them appear in Unity
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // FixedUpdate() is preferred to Update() when dealing with physics
    void FixedUpdate()
    {
        // The value of forwardForce is added to the Z axis
        // Time.deltaTime is the number of seconds since the last frame was drew. This means framerate will not affect the speed.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // When "d" is pressed, 500 will be added to the X axis.
        // VelocityChange means that mass will be ignored, making movement more responsive
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            // Runs the EndGame function in the GameManager script if the players y position is less than 1
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
