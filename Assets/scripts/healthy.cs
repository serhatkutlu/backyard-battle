using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthy : MonoBehaviour
{
    [SerializeField] float health = 100;
    [SerializeField]GameObject deadvfx;

public void dealdamage(float damage)
    {
        health -= damage;
        
        if (health<=0)
        {
            triggerdeadvfx();
            Destroy(gameObject);
        }
    }

    private void triggerdeadvfx()
    {
        if (!deadvfx) { return; }
        Instantiate(deadvfx,transform.position,transform.rotation);
    }
}
