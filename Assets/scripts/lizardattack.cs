using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizardattack : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherobj = collision.gameObject;
        if (otherobj.GetComponent<deffender>())
        {
            GetComponent<walking>().attack(otherobj);
        }
    }
 

}
