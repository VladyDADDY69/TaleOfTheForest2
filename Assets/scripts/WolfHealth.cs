using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WolfHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Slider HealthBar;
    void Start()
    {
        HealthBar.value = currentHealth;
        currentHealth = maxHealth;
        HealthBar.value = currentHealth;
    }
    void Update()
    {

    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        HealthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}