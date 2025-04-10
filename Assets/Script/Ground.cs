using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject floor;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Instantiate(floor, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
