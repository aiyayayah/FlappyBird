using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform spawnPoint;
    void Start()
    {
        Instantiate(obstacles[3], spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
