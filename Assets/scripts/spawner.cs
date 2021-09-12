using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [Range (1,25)]
    [SerializeField] float mindelay,maxdelay;
    public bool spawn=false;
    [SerializeField] walking[] enemyarray;
    [SerializeField] int value=4;

IEnumerator Start ()
    {
        //PlayerPrefs.SetInt("level index", );
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(mindelay, maxdelay));
            spawnattacker();
            
        }


    }
    private void Update()
    {
        levelComplicate(value);
    }


    public void spawnchange()
    {
        spawn = !spawn;
    }

    private void spawnattacker()
    {
        if (spawn)
        {
            var enemy = enemyarray[Random.Range(0, enemyarray.Length)];
            spawnenemy(enemy);
        }
       
    }
    private void spawnenemy (walking myenemy)
    {
 
            walking walk = Instantiate(myenemy, transform.position, transform.rotation);
            walk.transform.parent = transform;
        
        
    }
    void levelComplicate(int value)
    {
        if (Time.timeSinceLevelLoad>40)
        {
            maxdelay = value;
        }
    }

}
