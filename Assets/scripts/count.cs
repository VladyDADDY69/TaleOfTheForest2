using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class count : MonoBehaviour
{
    private int clue = 0;
    private int clues = 0; 
    [SerializeField] private Text CluesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Clue"))
        {
            Destroy(collision.gameObject);
            clue++;
            CluesText.text = "Clue: " + clue;
            Debug.Log("clues:" + clue);
        }
        
    }
    public void SaveData()
    {
        PlayerPrefs.SetInt("clues", clue);

    }
    private void Awake()
    {
        clues = PlayerPrefs.GetInt("clues") + clue;
        
    }
}
