using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 0f;
    public Rigidbody2D rb;
   void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 0 means mouse's left click
        {
            rb.velocity = new Vector2(0, speed); // 0 speed for x
        }
    }
}
