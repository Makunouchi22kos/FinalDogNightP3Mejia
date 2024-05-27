using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

    public int damageAmount = 20;

   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Enemy");
        {
            
             other.GetComponent<EnemyHealth>().EnemyDamage(damageAmount);
             Debug.Log("Hit");
        }
    }

    
}
