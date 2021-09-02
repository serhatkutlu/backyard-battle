using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livecollider : MonoBehaviour
{
    livestext livestext;
    private void Start()
    {
        
        livestext = GameObject.FindObjectOfType<livestext>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<walking>())
        {
            livestext.spendslives(1);
            Destroy(collision);
        }
    }
}
