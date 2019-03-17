using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    // this function is called by the animator
    public void loadNextLevel()
    {
        // The scene manager gets the next scene in the build index and loads it
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
