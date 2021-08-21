using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defender_spawner : MonoBehaviour
{

    [SerializeField] GameObject cactusprefab;
    private void OnMouseDown()
    {
        spawndefender(getsquareclick());
    }
    Vector2 getsquareclick()
    {
        Vector2 clickpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return clickpos;
    }

    private void spawndefender(Vector2 posision)
    {
        GameObject cactus = Instantiate(cactusprefab,posision,Quaternion.identity);
    }
}
