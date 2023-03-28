using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueScript : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue1;
    public GameObject[] answers;
    private int index = 0;
    public float speed;
    public GameObject button;
    public string scene1;
    public string scene2;

    void Start()
    {
        dialoguePanel.SetActive(true);
        StartCoroutine(Type());

    }

    // Update is called once per frame
    void Update()
    {

        if (dialogueText.text == dialogue1[index])
        {
            button.SetActive(true);
        }


    }
    IEnumerator Type()
    {
        foreach (char letter in dialogue1[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(speed);
        }
    }
    public void NextLine()
    {
        button.SetActive(false);
        if (index < dialogue1.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Type());
        }
        else
        {
            button.SetActive(false);
            for (int i = 0; i < answers.Length; i++)
            {
                answers[i].SetActive(true);
            }
        }
    }
    public void Option1()
    {

        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }

        
        SceneManager.LoadScene(scene1);




    }
    public void Option2()
    {

        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        
        SceneManager.LoadScene(scene2);
    }
}