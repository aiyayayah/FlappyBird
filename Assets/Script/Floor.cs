using UnityEngine;

public class Floor : MonoBehaviour
{
    public float floorMovingSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 30.0f);

        // Ensure it's not affected by gravity
        rb.gravityScale = 0;

        // Freeze the Y position in Rigidbody2D constraints (should also be done in Inspector)
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update()
    {
        rb.velocity = new Vector2(-floorMovingSpeed, 0);
    }
}
