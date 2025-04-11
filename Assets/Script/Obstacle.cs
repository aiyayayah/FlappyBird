using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameManager gm;
    public float PillarMovingSpeed = 5f;

    void Start()
    {
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        Destroy(gameObject, 30.0f);  //the pillar disappear after 30s
    }

    void Update()
    {
        if(!gm.PlayerDead == true)
        {
            //pillar move to left
            transform.Translate(new Vector3(-PillarMovingSpeed * Time.deltaTime, 0, 0));
            //time.delta time change the unit from frame fps to second
        }
    }
}
