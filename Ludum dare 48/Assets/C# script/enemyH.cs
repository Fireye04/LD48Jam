using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemyH : MonoBehaviour
{
    public GameObject sword;
    private playerCombat PA;
    public int maxHealth = 10;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        PA = sword.GetComponent<playerCombat>();

    }
    public void damage(int hp)
    {
        currentHealth -= hp ;
        if (currentHealth <= 0)
        {
            die();
        }
    }
    
    void die()
    {
        GetComponent<Collider2D>().enabled = false;
    //    PA.damage1++;

    }

}
