using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deffenderbutton : MonoBehaviour
{
    [SerializeField] deffender deffenderpref;
    defender_spawner spawner;
    
    private void Start()
    {
        spawner = GameObject.FindObjectOfType<defender_spawner>();
        labelButton();
    }

    private void labelButton()
    {
        Text labeCostText = GetComponentInChildren<Text>();
        if (labeCostText)
        {
            labeCostText.text = deffenderpref.getstarcost().ToString();
        }
        
    }

    private void OnMouseDown()
    {
        var buttons = GameObject.FindObjectsOfType<deffenderbutton>();
        foreach (deffenderbutton buton in buttons)
        {
            buton.GetComponent<SpriteRenderer>().color = new Color32(70, 70, 70,255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        spawner.setselecteddeffender(deffenderpref);
    }
    
 
}
