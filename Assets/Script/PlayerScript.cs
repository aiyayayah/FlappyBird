using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float jumpHeight = 0f;
    public Rigidbody2D rb;
    public int score = 0;
   void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) // 0 means mouse's left click
        {
            rb.velocity = new Vector2(0, jumpHeight); // 0 speed for x
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //built in function -- collide
    {
        if (collision.gameObject.tag == "Pillar")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0; //stop the game
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
}
