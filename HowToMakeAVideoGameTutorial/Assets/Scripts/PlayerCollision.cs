using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Creates a reference to the PlayerMovement script
    public PlayerMovement movement;

    // This function runs whenever a collision occours and saves the information as "collisionInfo"
    private void OnCollisionEnter(Collision collisionInfo)
    {
        // This will only run if the player collides with an object with the "Obstacle" tag
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Disables the PlayerMovement script with the name we have referenced it as
            movement.enabled = false;
            // Runs the EndGame function from the GameManager script
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
