using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravestone : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        walking attacker = collision.transform.GetComponent<walking>();
        if (attacker)
        {

        }
    }
}
