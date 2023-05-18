using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }
}
