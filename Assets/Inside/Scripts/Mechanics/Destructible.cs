using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    float resistance = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {

            TakeDamage(collision.gameObject.GetComponent<Projectile>().GetDamageAmount());

        }
    }


    void TakeDamage(float damage)
    {
        resistance -= damage;
        if (resistance <= 0)
        {
            GetComponent<Dropper>().Drop(transform.position);
            Destroy(gameObject);
        }

    }
}
