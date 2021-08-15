using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [Range (1,5)]
    [SerializeField] float mindelay,maxdelay;
    bool spawn=true;
    [SerializeField] walking enemy;

IEnumerator Start ()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(mindelay, maxdelay));
            spawnattacker();
        }

    }

    private void spawnattacker()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
