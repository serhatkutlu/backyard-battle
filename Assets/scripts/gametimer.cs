using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gametimer : MonoBehaviour
{
    [Tooltip("our level timer in seconds")]
    [SerializeField] float time = 10;
    
    bool starttime=false;
    bool triggeredLevelFinished;
    bool timefinish;
    private void Update()
    {
        if (triggeredLevelFinished)
        {
            return;
        }
        if (!starttime)
        {
            time += Time.deltaTime; 
        }
        else
        {
            GetComponent<Slider>().value = Time.timeSinceLevelLoad / time;
             timefinish = Time.timeSinceLevelLoad >= time;
        }
        
       

        if (timefinish)
        {
            FindObjectOfType<levelcontroller>().leveltimerfinished();
            triggeredLevelFinished = true;
        }
    }
    public void startime()
    {
        starttime = true;
    }
}
