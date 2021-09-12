using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelcontroller : MonoBehaviour
{
    MUSÝCPLAYER MUSÝCPLAYER;
    int nunberOfAttackers = 0;
    public bool leveltimerfinish;
    public GameObject winlabel,loselabel;
    private void Start()
    {
        MUSÝCPLAYER= FindObjectOfType<MUSÝCPLAYER>();
        if (winlabel)
        {
            winlabel.SetActive(false);
            loselabel.SetActive(false);
        }
        
    }
    private void Update()
    {
        if (nunberOfAttackers<=0)
        {
            attackerKiller();

        }
    }
    public void attackerSpawner()
    {
        nunberOfAttackers++;
    }
    public void attackerKiller()
    { nunberOfAttackers--;
        
        if (nunberOfAttackers<=0&&leveltimerfinish)
        {
            if (!winlabel.activeSelf)
            {
                StartCoroutine(handleWinCondition());
            }
            
        }
    }
    IEnumerator handleWinCondition()
    {
        MUSÝCPLAYER.GetComponent<AudioSource>().Stop();
        MUSÝCPLAYER.mainAudioClip();
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
            item.spawnchange();
        }
    }

}
