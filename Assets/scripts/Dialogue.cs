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
    public string[] dialogue1;
    public string[] dialogue2;
    public GameObject[] answers;
    private int index = 0;
    private int index1 = 0;
    private int index2 = 0;
    public float wordSpeed;
    public GameObject contButton;
    private int nextSceneToLoad;
    private int k;
    public int numberOfSentences;

    void Start()
    {
        dialoguePanel.SetActive(true);
        StartCoroutine(Typing());
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
        if (index == dialogue.Length)
        {
            dialoguePanel.SetActive(false);
        }
        if(k== numberOfSentences)
        {
            for(int i=0;i<answers.Length;i++)
            {
                answers[i].SetActive(true);
            }
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
    IEnumerator Typing1()
    {
        foreach (char letter in dialogue1[index1].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    IEnumerator Typing2()
    {
        foreach (char letter in dialogue2[index2].ToCharArray())
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
            k++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else if(index1 < dialogue1.Length - 1)
        {
            index1++;
            
            dialogueText.text = "";
            StartCoroutine(Typing1());
        }
        else if (index2 < dialogue2.Length - 1)
        {
            index2++;

            dialogueText.text = "";
            StartCoroutine(Typing1());
        }
        else
        {
            dialogueText.text = "";
            contButton.SetActive(false);
            dialoguePanel.SetActive(false);
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
    public void Option1()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
       
        StartCoroutine(Typing1());
        
    }
    public void Option2()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        dialogueText.text = (dialogue2[0]);
        
        StartCoroutine(Typing2());
        
    }


}