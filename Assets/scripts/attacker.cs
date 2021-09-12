using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacker : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<deffender>())
        {
            GetComponent<walking>().attack(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<deffender>())
        {
            GetComponent<Animator>().SetTrigger("ÝsAttacking");
        }
    }
    public void dead()
    {
        Destroy(this.gameObject);
    }

}
