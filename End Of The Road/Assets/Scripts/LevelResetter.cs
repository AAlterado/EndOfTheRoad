using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelResetter : MonoBehaviour
{
    public void ResetLevel()
    {
        // Reload the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
