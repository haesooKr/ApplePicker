using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float changeToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        } else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        } 
    }

    void FixedUpdate()
    {
        if(Random.value < changeToChangeDirections)
        {
            speed *= -1;
        }
    }
}
