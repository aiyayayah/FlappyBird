using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float jumpHeight = 0f;
    public Rigidbody2D rb;
    public int score = 0;

    public GameManager gm;
    public GameObject endGameUI;
    public Text scoreTextNow;
    public GameObject[] medals;
    public GameObject scoreBackground;
  void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) // 0 means mouse's left click
        {
            if(gm.PlayerDead == false)
            {
                rb.velocity = new Vector2(0, jumpHeight); // 0 speed for x
            }
        }

        Quaternion rotation = transform.rotation;

        Quaternion targetRotation;

        if (rb.velocity.y > 0) //bird is moving up
        {
            targetRotation = Quaternion.Euler(0, 0, 30);
        }

        else if ((rb.velocity.y < 0)) //bird is moving down 
        {
            targetRotation = Quaternion.Euler(0, 0, -30); //make the bird face down 30 degree
        }

        else
        {
            targetRotation = Quaternion.Euler(0, 0, 0);
        }
        transform.rotation = Quaternion.RotateTowards(rotation, targetRotation, 600 * Time.deltaTime);

        if (gm.GameStart == true)
        {
            FreeBird();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //built in function -- collide
    {
        if (collision.gameObject.tag == "Pillar")
        {
            GameEnd();
        }
        else if (collision.gameObject.tag == "Floor")
        {
            GameEnd();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision) //built in function  -- trigger
    {
        if(collision.gameObject.tag == "ADDScore")
        {
            score++;
            Debug.Log(score);
        }
    }

    private void GameEnd()
    {
        gm.PlayerDead = true;
        Invoke("StopGame", 0.8f); //stop the bird flying
    }

    private void FreeBird()
    {
        rb.constraints = RigidbodyConstraints2D.None; 
    }

    public void StopGame()
    {
        Time.timeScale = 0;
        endGameUI.SetActive(true);
        scoreBackground.SetActive(false);
        scoreTextNow.text = score.ToString();

        if(score > 15)
        {
            medals[0].SetActive(true);
        }
        else if(score>10)
        {
            medals[1].SetActive(true);
        }
        else
        {
            medals[2].SetActive(true);
        }
    }
}
