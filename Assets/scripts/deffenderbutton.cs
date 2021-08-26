using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deffenderbutton : MonoBehaviour
{
    [SerializeField] deffender deffenderpref;
    defender_spawner spawner;
    private void Start()
    {
        spawner = GameObject.FindObjectOfType<defender_spawner>();
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
