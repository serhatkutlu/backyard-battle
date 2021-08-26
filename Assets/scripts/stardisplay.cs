using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stardisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text startext;
    void Start()
    {
        startext = GetComponent<Text>();
        updatedisplay();
    }

    private void updatedisplay()
    {
        startext.text = stars.ToString();
    }
    public bool HaveEnoughtStars(int ammout)
    {
        return stars >= ammout;
    }
    public void addstars(int amount)
    {
        stars += amount;
        updatedisplay();
    }
    public void spendstars(int amount)
    {
        stars -= amount;
        updatedisplay();
    }
}
