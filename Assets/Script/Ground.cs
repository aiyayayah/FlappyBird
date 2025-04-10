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
        if (collision.gameObject.tag == "Floor" && floor != null)
        {
            Instantiate(floor, spawnPoint.position, spawnPoint.rotation);
            Debug.Log("New floor spawned at " + spawnPoint.position);

        }
    }
}
