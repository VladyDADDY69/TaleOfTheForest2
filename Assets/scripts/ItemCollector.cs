using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int clue = 0;
    [SerializeField] private Text CluesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Clue"))
        {
            Destroy(collision.gameObject);
            ClueTransfer.totalClues = clue;
            clue++;
            CluesText.text = "Clues: " + clue;
        }
    }
    public void GetClues()
    {
        int recievedClues = ClueTransfer.totalClues;
        CluesText.text = "Clues: " + recievedClues;
    }
}
