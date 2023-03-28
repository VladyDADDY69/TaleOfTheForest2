using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Slider HealthBar;
    public string scene;
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
            SceneManager.LoadScene(scene);

        }
    }
}