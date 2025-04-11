using UnityEngine;
using UnityEngine.UI;

public class ScoreNumber : MonoBehaviour
{
    public PlayerScript pScript;
    public Text scoreText;
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = pScript.score.ToString();
    }
}
