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
        nextlevelload();
    }
    public void nextlevelload()
    {
        SceneManager.LoadScene(activescene + 1);
    }
    public void tryAgain()
    {
        SceneManager.LoadScene(activescene );
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("startscreen");
    }
    public void losescreen()
    {
        SceneManager.LoadScene("loseScreen");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
