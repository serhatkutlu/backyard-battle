using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox: MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherobj = collision.gameObject;
        if (otherobj.GetComponent<gravestone>()|| otherobj.CompareTag("trophy cut"))
        {
            GetComponent<Animator>().SetTrigger("jump");

        }
        if (collision.GetComponent<sooting>())
        {
            GetComponent<walking>().attack(collision.gameObject);
            GetComponent<Animator>().SetTrigger("attack");
        }
 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<sooting>())
        {
            
            GetComponent<Animator>().SetTrigger("attack");
        }

    }


}
