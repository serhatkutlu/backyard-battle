using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gametimer : MonoBehaviour
{
    [Tooltip("our level timer in seconds")]
    [SerializeField] int time = 10;
    bool triggeredLevelFinished;
    private void Update()
    {
        if (triggeredLevelFinished)
        {
            return;
        }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / time;
        bool timefinish = Time.timeSinceLevelLoad >= time;

        if (timefinish)
        {
            FindObjectOfType<levelcontroller>().leveltimerfinished();
            triggeredLevelFinished = true;
        }
    }
}
