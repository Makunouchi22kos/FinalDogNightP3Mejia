using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    [SerializeField] float damage;
    
    public GameObject R_Wrist;

    public void EnableWristCollider(int isEnabled)
    {
        var col = R_Wrist.GetComponent<Collider>();

        if(col != null)
        {

            if(isEnabled == 1)
            {
                col.enabled = true;
            }
            else
            {
                col.enabled = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<CharacterStats>().TakeDamage(damage);

        }
    }
}
