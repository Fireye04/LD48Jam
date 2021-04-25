using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int damage1=1;


    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }
    void Attack()
    {
        animator.SetTrigger("sword");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<enemyH>().damage(damage1);
            Debug.Log("hit");   
        }


    }


    void OnDrawGizmosSelected()
    {
        if(attackPoint ==null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
