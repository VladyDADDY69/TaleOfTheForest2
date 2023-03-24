using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCombat2 : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint2;
    public float attackRange2 = 0.5f;
    public LayerMask enemyLayers2;
    public int attackDamage2 = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Attack2();
        }
    }
    void Attack2()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint2.position, attackRange2, enemyLayers2);
        foreach (Collider2D enemy in hitEnemies)
        {
            Destroy(enemy);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint2 == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint2.position, attackRange2);
    }
}
