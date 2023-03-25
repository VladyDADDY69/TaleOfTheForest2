using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{

	public int health = 500;

	public GameObject deathEffect;

	public bool isInvulnerable = false;

	public Slider healthBar;
	public void TakeDamage(int damage)
	{
		
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
		healthBar.value = health;
	}

	void Die()
	{
		//Alex, la partea asta bagi choice ul daca il omoara sau nu
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}