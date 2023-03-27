using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NpcTalk : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] sentences;
    public GameObject[] answers;
    private int index = 0;
    private bool canContinue;
    private int nextSceneToLoad;
    private int option;
    public float speed;
    void Start()
    {
        //for(int i=0;i< answers.Length;i++)
        //{
        // answers[i].SetActive(true);
        // }
        dialoguePanel.SetActive(true);
        StartCoroutine(Type());

    }

    // Update is called once per frame
    void Update()
    {


        /* if(canContinue && Input.GetMouseButtonDown(0))
         {
             index++;

             if (option==1)
             {
                 dialoguePanel.SetActive(true);
                 dialogueText.text = (dialogue1[index]);
             }
             else if (option == 2)
             {
                 dialoguePanel.SetActive(true);
                 dialogueText.text = (dialogue2[index]);
             }
             if (index == dialogue1.Length - 1 || index == dialogue2.Length - 1)
             {

             }

         }
         dialoguePanel.SetActive(true);
         dialogueText.text = (dialogue1[index]);*/

    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(speed);
        }
        
    }
    /* public void Option1()
     {
         option = 1;
         for (int i = 0; i < answers.Length; i++)
         {
             answers[i].SetActive(false);
         }
         canContinue = true;
         nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
         SceneManager.LoadScene(nextSceneToLoad);




     }
     public void Option2()
     {
         option = 2;
         for (int i = 0; i < answers.Length; i++)
         {
             answers[i].SetActive(false);
         }
         canContinue = true;
         dialoguePanel.SetActive(true);
         dialogueText.text = (dialogue2[index]);
         nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 2;
         SceneManager.LoadScene(nextSceneToLoad);


     }*/


}