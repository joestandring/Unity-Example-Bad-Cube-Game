using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Variable player is equal to the transform data for the player object
    public Transform player;
    // Variable scoreText is equal to the text object
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // changes the text value of the text object to the z position of the player as a whole number
        scoreText.text = player.position.z.ToString("0");
    }
}
