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
            bool ÝsCloseEnought = Mathf.Abs( attacker.transform.position.y-0.2f- transform.position.y) <= Mathf.Epsilon+0.1f;                        
            
            if (ÝsCloseEnought)
            {
                

                MyLaneSpawner = attacker;
            }
        }
    }

    private void Update()
    {
        if (ÝsAttackerÝnLane())
        {
            cactusanim.SetBool("ÝsAttacking",true);
           
        }
        else
        {
            cactusanim.SetBool("ÝsAttacking", false);
        }
        
            
        
  
    }
    private bool ÝsAttackerÝnLane()
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
        var projectileÝnstant =Instantiate(zucchini_prefab,transform.position,transform.rotation);
        projectileÝnstant.transform.SetParent(projectile.transform);
       
    }
}
