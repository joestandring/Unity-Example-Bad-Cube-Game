using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    // When the level is complete activate the UI telling the player they have won
    public void completeLevel()
    {
        Debug.Log("Level won!");
        completeLevelUI.SetActive(true);
    }

    // public is used to access this script in other scripts using FindObjectOfType
    public void EndGame()
    {
        // Doing this means that once the game has ended, it cannot be ended again. The restart function will also be run
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            // Invoke calls a function after an amount of time has passed
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        // The active scene will be reloaded
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
