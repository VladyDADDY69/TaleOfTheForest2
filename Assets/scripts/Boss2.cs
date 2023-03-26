using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Boss")
        {
            collision.gameObject.GetComponent<BossHealth>().TakeDamage(4);
        }
    }
}