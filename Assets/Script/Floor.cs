using UnityEngine;

public class Floor : MonoBehaviour
{
    public float floorMovingSpeed = 5f;

    void Start()
    {
        Destroy(gameObject, 30.0f);  //the pillar disappear after 30s
    }

    void Update()
    {
        //pillar move to left
        transform.Translate(new Vector3(-floorMovingSpeed * Time.deltaTime, 0, 0));
        //time.delta time change the unit from frame fps to second
    }
}
