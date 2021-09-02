using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroller : MonoBehaviour
{
    int nunberOfAttackers = 0;
    public bool leveltimerfinish;
    public GameObject winlabel,loselabel;
    private void Start()
    {
        if (winlabel)
        {
            winlabel.SetActive(false);
            loselabel.SetActive(false);
        }
        
    }
    public void attackerSpawner()
    {
        nunberOfAttackers++;
    }
    public void attackerKiller()
    { nunberOfAttackers--;
        print(nunberOfAttackers);
        if (nunberOfAttackers<=0&&leveltimerfinish)
        {
            StartCoroutine(handleWinCondition());
        }
    }
    IEnumerator handleWinCondition()
    {
        yield return new WaitForSeconds(1);
        winlabel.SetActive(true);
        yield return new WaitForSeconds(4);
        FindObjectOfType<levelloader>().nextlevelload();
    }
    public void leveltimerfinished()
    {
        leveltimerfinish = true;
        stopspawners();
    }

    private void stopspawners()
    {
        spawner[] spawners = FindObjectsOfType<spawner>();
        foreach (var item in spawners)
        {
            item.stopspawn();
        }
    }

}
