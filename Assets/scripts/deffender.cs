using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deffender : MonoBehaviour
{
    [SerializeField] int starcost = 100;
    public void staradd(int amount)
    {
        GameObject.FindObjectOfType<stardisplay>().addstars(amount);
    }
    public int getstarcost()
    {
        return starcost;
    }
}
