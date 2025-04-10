using UnityEngine;

public class Floor : MonoBehaviour
{
    public float floorMovingSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 30.0f);

      
        rb.gravityScale = 0;

        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update()
    {
        rb.velocity = new Vector2(-floorMovingSpeed, 0);
    }
}
