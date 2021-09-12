using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSİCPLAYER : MonoBehaviour
{
    [SerializeField] AudioClip mainmusic, warmusic;
    private void Awake()
    { MUSİCPLAYER[] list = FindObjectsOfType<MUSİCPLAYER>();
        if (list.Length>1)
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        FindObjectsOfType<MUSİCPLAYER>();
            DontDestroyOnLoad(this);
        
        
        GetComponent<AudioSource>().volume = playerprefbs.getMasterVolume();
    }

public void setvolume(float vol)
    {
        GetComponent<AudioSource>().volume = vol;
    }
    public void warAudioClip()
    {
        GetComponent<AudioSource>().clip = warmusic;
    }
    public void mainAudioClip()
    {
        GetComponent<AudioSource>().clip = mainmusic;
    }

}
