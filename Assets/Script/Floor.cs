using UnityEngine;

public class Floor : MonoBehaviour
{
    public float floorMovingSpeed = 2f;
    private Rigidbody2D rb;
    public GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        Destroy(gameObject, 60.0f);

      
        rb.gravityScale = 0;

        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update()
    {
        if (!gm.PlayerDead == true)
        {
            rb.velocity = new Vector2(-floorMovingSpeed, 0);
        }
    }
}
