using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue;
    private int index = 0;
    public float wordSpeed;
    public GameObject contButton;
    private int nextSceneToLoad;

    void Start()
    {
        dialoguePanel.SetActive(true);
        StartCoroutine(Typing());
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
       if(dialogueText.text== dialogue[index])
        {
            contButton.SetActive(true);
        }
       if(index== dialogue.Length)
        {
            dialoguePanel.SetActive(false);
        }
       
    }

    

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    public void NextLine()
    {
        contButton.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            dialogueText.text = "";
            contButton.SetActive(false);
            dialoguePanel.SetActive(false);
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
    


}