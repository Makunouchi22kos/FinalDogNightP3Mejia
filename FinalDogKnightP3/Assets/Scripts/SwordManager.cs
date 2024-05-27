using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordManager : MonoBehaviour
{

    public GameObject Weapon;

    public void EnableWeaponCollider(int isEnabled)
    {
        var col = Weapon.GetComponent<Collider>();

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
}
