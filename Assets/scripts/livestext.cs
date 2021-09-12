using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livestext : MonoBehaviour
{ 
    [SerializeField] float lives=0,baselives = 3;
     Text livetext;
    private void Start()
    {
        Time.timeScale = 1;
        lives = baselives - playerprefbs.getDifficult();
        livetext = transform.GetComponent<Text>();
        updatedisplay();
    }
    private void updatedisplay()
    {
        livetext.text = lives.ToString();
    }
    public void spendslives(int amount)
    {
        lives -= amount;
        updatedisplay();
        if (lives<=0)
        {
            FindObjectOfType<MUSÝCPLAYER>().GetComponent<AudioSource>().Stop();
            GameObject.FindObjectOfType<levelcontroller>().loselabel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
