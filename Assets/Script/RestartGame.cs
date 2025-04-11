using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{ 
    public void ResetGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
