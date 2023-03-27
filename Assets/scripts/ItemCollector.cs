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
            clue++;
            CluesText.text = "Minors: " + clue;
        }
    }
}
