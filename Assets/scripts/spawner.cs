using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [Range (1,5)]
    [SerializeField] float mindelay,maxdelay;
    bool spawn=true;
    [SerializeField] walking[] enemyarray;

IEnumerator Start ()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(mindelay, maxdelay));
            spawnattacker();
        }

    }
    public void stopspawn()
    {
        spawn = false;
    }

    private void spawnattacker()
    {
        var enemy = enemyarray[Random.Range(0, enemyarray.Length)];
        spawnenemy(enemy);
    }
    private void spawnenemy (walking myenemy)
    {
        walking walk = Instantiate(myenemy, transform.position, transform.rotation);
        walk.transform.parent = transform;
    }

}
