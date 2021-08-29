using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    [Range(0, 5)]
    [SerializeField] float walkspeed;
    float eventspeed=1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector2.left * eventspeed*Time.deltaTime );

    }
    public void animationspeed(float speed)
    {
        eventspeed = speed;
    }
}
