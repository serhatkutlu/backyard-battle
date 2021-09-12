using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class levelloader : MonoBehaviour
{
    
    [SerializeField] float waittotime=4;
    int activescene;
    void Start()
    {

        
        activescene = SceneManager.GetActiveScene().buildIndex;
        if (activescene==0)
        {
            StartCoroutine(startlevel());
        }
        
        
    }

 

IEnumerator  startlevel()
    {
        yield return new WaitForSeconds(waittotime);
        mainmenu();
    }
    public void nextlevelload()
    {
        int level = playerprefbs.setLevel();
        //check if next level exists level loaded
        if (SceneManager.sceneCountInBuildSettings==level+2)
        {
            level = playerprefbs.returnBeginLevel();
        }
        
        
        SceneManager.LoadScene("level"+level);
      
    }
    public void startbutton()
    {
       
        SceneManager.LoadScene("level"+playerprefbs.getLevel());
    }
    public void tryAgain()
    {
        SceneManager.LoadScene(activescene );
    }
    public void mainmenu()
    {

        MUSÝCPLAYER musicplayer = FindObjectOfType<MUSÝCPLAYER>();
        if (musicplayer)
        {
            musicplayer.mainAudioClip();
            musicplayer.GetComponent<AudioSource>().Play();
        }
        

        SceneManager.LoadScene("startscreen");
    }
    public void losescreen()
    {
        SceneManager.LoadScene("loseScreen");
    }
    public void optionscene()
    {
        SceneManager.LoadScene("optionscreen");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
