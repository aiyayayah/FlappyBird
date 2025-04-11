using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameManager gm;
    public GameObject startButtonUI;

    public void StartGame()
    {
        gm.GameStart = true; 
        startButtonUI.SetActive(false);
        Time.timeScale = 1;
    }
}
