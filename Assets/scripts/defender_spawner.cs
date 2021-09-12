using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defender_spawner : MonoBehaviour
{
    const string deffender_parent = "Deffender";
    GameObject deffenderParrent;

    deffender deffender;
    private void Start()
    {
        createParrentDeffender();
    }
    void createParrentDeffender()
    {
        deffenderParrent = GameObject.Find(deffender_parent);
        if (!deffenderParrent)
        {
            deffenderParrent = new GameObject(deffender_parent);
        }
    }
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

        
        clickpos = snaptogrid(clickpos);

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
        deffender deffender›nstant = Instantiate(deffender,posision,Quaternion.identity);
        deffender›nstant.transform.SetParent(deffenderParrent.transform);
    }
}
