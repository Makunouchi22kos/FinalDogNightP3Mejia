using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{

    public float currHealth;
    public float maxHealth;
    private bool isDead;
    public float minHealth;

    public Animator transition;

    public Animator anim;

    public HealthBar healthBar;

    //Sets the Health Bar to max at the beginning of the game.
    void Start()
    {
        currHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }

    //Checks how much health the player has.
    public virtual void CheckHealth()
    {
        if (currHealth >= maxHealth)
        {
            currHealth = maxHealth;
        }

    }

    // Checks the damage the player has taken and changes the health bar.
    public void TakeDamage(float damage)
    {
        currHealth -= damage;

        healthBar.SetSlider(currHealth);
    }

    void Die()
    {
        if (currHealth == minHealth)
        {
                SceneManager.LoadScene(2);
                transition.SetTrigger("Start");
        }
               
    }
}
