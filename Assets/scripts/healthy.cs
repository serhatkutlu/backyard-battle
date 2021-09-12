using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthy : MonoBehaviour
{
    [SerializeField] float health = 100;


public void dealdamage(float damage)
    {
        health -= damage;
        
        if (health<=0)
        {
            if (GetComponent<attacker>())
            {
                GetComponent<Animator>().SetTrigger("dead");
            }
            else
            {
                Destroy(gameObject);
            }
           
        }
    }


}
