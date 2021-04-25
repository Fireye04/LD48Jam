using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public healthbar healthBar;



    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

    }

    void TakeDamage(int Damage)
    {
        currentHealth -= Damage;
        healthBar.SetHealth(currentHealth);
    }
}

