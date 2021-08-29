using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livestext : MonoBehaviour
{
    [SerializeField] int lives = 5;
     Text livetext;
    private void Start()
    {
        livetext = transform.GetComponent<Text>();
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
            GameObject.FindObjectOfType<levelcontroller>().loselabel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
