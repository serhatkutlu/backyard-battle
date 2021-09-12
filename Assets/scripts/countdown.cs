using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{ 
    gametimer gametimer;
    MUS�CPLAYER MUS�CPLAYER;
    Text text;
    [SerializeField] float time;
    private IEnumerator Start()
    {
       
        gametimer = FindObjectOfType<gametimer>();
        text = GetComponent<Text>();
        yield return new WaitForSeconds(1);
        text.text = "level"+playerprefbs.getLevel();
        yield return new WaitForSeconds(time);
        text.text = "3";
        yield return new WaitForSeconds(time);
        text.text = "2";
        yield return new WaitForSeconds(time);
        text.text = "1";
        yield return new WaitForSeconds(time);
        text.enabled = false;
        gametimer.startime();
        setmusic();
        spawner_change();
    }

    private void setmusic()
    {
        MUS�CPLAYER = FindObjectOfType<MUS�CPLAYER>();
        MUS�CPLAYER.warAudioClip();

        MUS�CPLAYER.GetComponent<AudioSource>().Play();
        
        
    }

    private void spawner_change()
    {
        spawner[] spawners = FindObjectsOfType<spawner>();
        foreach (var item in spawners)
        {
            item.spawnchange();

        }
    }
}
