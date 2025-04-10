using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameManager gm;
    public GameObject startButtonUI;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        gm.GameStart = true; 
        startButtonUI.SetActive(false);
    }
}
