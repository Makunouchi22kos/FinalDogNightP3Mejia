using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndCollision : MonoBehaviour
{

     void OnTriggerEnter(Collider collision)
     {
         if (collision.gameObject.tag == "Enemy")
         {
             Debug.Log("Enter");
         }
     }
}
