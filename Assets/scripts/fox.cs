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
            
            GetComponent<Animator>().SetBool("jump", true);
            StartCoroutine(jumpBugFix());


        }
        if (collision.GetComponent<sooting>()&&! GetComponent<Animator>().GetBool("jump"))
        {  
            GetComponent<walking>().attack(collision.gameObject);
           
        }
        

    }
    IEnumerator jumpBugFix()
    {
        yield return new WaitForSeconds(0.2f);
        GetComponent<Animator>().SetBool("jump", false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<sooting>())
        {
            
            GetComponent<Animator>().SetTrigger("ÝsAttacking");
        }

    }


}
