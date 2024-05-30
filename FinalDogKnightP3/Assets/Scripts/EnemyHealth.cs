using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int HP = 100;
    public Animator anim;


    Spawner spawn;
    


    private void Start()
    {
        spawn = GameController.GetComponentInChildren<Spawner>();
    }


    public void EnemyDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            
            anim.SetTrigger("Die");
            GetComponent<Collider>().enabled = false;
            GetComponent<EnemyFollow>().enabled = false;  
        }

        if (spawn.enemiesKilled >= spawn.enemySpawnAmount)
        {
            spawn.NextWave();
        }
        else
        {
            spawn.enemiesKilled++;
        }
        
    }


}
