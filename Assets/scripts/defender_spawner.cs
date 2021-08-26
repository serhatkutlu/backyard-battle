using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defender_spawner : MonoBehaviour
{

    deffender deffender;
    private void OnMouseDown()
    {
        AttemptTOplaceDeffenderAt(getsquareclick());
    }
    public void setselecteddeffender(deffender deffendertoselect)
    {
        deffender = deffendertoselect;
    }
    void AttemptTOplaceDeffenderAt(Vector2 gridpos)
    {
        stardisplay stardisplay = GameObject.FindObjectOfType<stardisplay>();
        int deffendercost = deffender.getstarcost();
        if (stardisplay.HaveEnoughtStars(deffendercost))
        {
            spawndefender(gridpos);
            stardisplay.spendstars(deffendercost);
        }
    }
    Vector2 getsquareclick()
    {
        Vector2 clickpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        print(clickpos);
        
        clickpos = snaptogrid(clickpos);
        print(clickpos);
        return clickpos;
    }
    Vector2 snaptogrid(Vector2 posision)
    {
        int newX = Mathf.RoundToInt(posision.x);
        int newY = Mathf.RoundToInt(posision.y);
        return new Vector2(newX,newY);
    }

    private void spawndefender(Vector2 posision)
    {
        deffender cactus = Instantiate(deffender,posision,Quaternion.identity);
    }
}
