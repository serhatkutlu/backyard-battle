using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sooting : MonoBehaviour
{
    [SerializeField]
    GameObject zucchini_prefab;
    [SerializeField] float speed;
    void Start()
    {
        
    }

public void soot(float damage)
    {
        Instantiate(zucchini_prefab,transform.position,transform.rotation);
       
    }
}
