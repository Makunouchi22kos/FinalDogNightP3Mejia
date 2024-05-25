using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public float currHealth;
    public float maxHealth;
    public float minHealth;

    public Animator anim;

    public HealthBar healthBar;

    void Start ()
    {
        currHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }

    public virtual void CheckHealth()
    {
        if (currHealth >= maxHealth)
        {
            currHealth = maxHealth;
        }

    }

    public void TakeDamage(float damage)
    {
        currHealth -= damage;

        healthBar.SetSlider(currHealth);
    }
    
    public void Die()
    {
        
        if (currHealth == minHealth)
        {
            anim.SetTrigger("Death");
        }
    }

    
}
