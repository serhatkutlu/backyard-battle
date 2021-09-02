using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zucchini : MonoBehaviour
{

    [SerializeField] float move_speed, rotate_speed,damage=50;

    private void Update()
    {
        zucchini_moveandturn(move_speed, rotate_speed);
    }
    void zucchini_moveandturn(float move_speed, float rotate_speed)
    {
        transform.position += Vector3.right * Time.deltaTime * move_speed;
        transform.Rotate(Vector3.forward * Time.deltaTime * rotate_speed);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<walking>())
        {
            
            collision.GetComponent<healthy>().dealdamage(damage);
            Destroy(this.gameObject);
        }
    }

}

