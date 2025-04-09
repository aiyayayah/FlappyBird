using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float PillarMovingSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pillar move to left
        transform.Translate(new Vector3(-PillarMovingSpeed * Time.deltaTime, 0, 0));
        //time.delta time change the unit from frame fps to second
    }
}
