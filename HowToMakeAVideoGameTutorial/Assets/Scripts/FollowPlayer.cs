using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Gets the players position and saves as variable "player"
    public Transform player;
    // The "Vector3" data type stores 3 float numbers
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Camera position is set to the players position
        transform.position = player.position + offset;
    }
}
