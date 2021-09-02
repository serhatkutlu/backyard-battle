using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sooting : MonoBehaviour
{
    [SerializeField]
    GameObject zucchini_prefab;
   
    spawner MyLaneSpawner;
    Animator cactusanim;
    GameObject projectile;
    const string projectileParentName = "projectile";
    private void Start()
    {
        SetAttackerSpawners();
        cactusanim = GetComponent<Animator>();
        createParrentProjectile();
    }
    void createParrentProjectile()
    {
        projectile = GameObject.Find(projectileParentName);
        if (!projectile)
        {
            projectile = new GameObject(projectileParentName);
        }
    }
    private void SetAttackerSpawners()
    {
        spawner[] attackers = GameObject.FindObjectsOfType<spawner>();
        foreach (var attacker in attackers)
        {

            print(transform.position.y);
            bool �sCloseEnought = Mathf.Abs( attacker.transform.position.y-0.2f- transform.position.y) <= Mathf.Epsilon+0.1f;                        
            
            if (�sCloseEnought)
            {
                

                MyLaneSpawner = attacker;
            }
        }
    }

    private void Update()
    {
        if (�sAttacker�nLane())
        {
            cactusanim.SetBool("�sAttacking",true);
           
        }
        else
        {
            cactusanim.SetBool("�sAttacking", false);
        }
        
            
        
  
    }
    private bool �sAttacker�nLane()
    {
        if (MyLaneSpawner.transform.childCount<=0)
        {
           
            return false;
        }
        else
        {
            print(MyLaneSpawner);
            return true;
        }


    }
    public void soot(float damage)
    {
        var projectile�nstant =Instantiate(zucchini_prefab,transform.position,transform.rotation);
        projectile�nstant.transform.SetParent(projectile.transform);
       
    }
}
