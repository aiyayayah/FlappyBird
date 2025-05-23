using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform spawnPoint;
    public bool doCreate = true;
    public float nextPillarCreationTime = 1.0f;
    public GameManager gm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gm.PlayerDead)
        {
            if (gm.GameStart == true)
            {
                if (doCreate)
                {
                    int randomIndex = Random.Range(0, obstacles.Length);

                    Instantiate(obstacles[randomIndex], spawnPoint.position, spawnPoint.rotation);

                    Invoke("ResetDoCreate", nextPillarCreationTime); //delay time after nextPillarCreated
                    doCreate = false; //prevent immediate respawn
                }
            }
        }
      
        
    }

    public void ResetDoCreate()
    {
        doCreate = true;   
    }
}
