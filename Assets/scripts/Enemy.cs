using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int mxh = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = mxh;
    }

    public void TakeDam(int dam)
    {
        currentHealth -= dam;
        if(currentHealth <= 0)
        {
            Died();
        }
    }
    void Died()
    {
        Debug.Log("Enemy died!");
    }
}
