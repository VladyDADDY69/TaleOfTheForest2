using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue1 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue1;
    public string[] dialogue2;
    public GameObject[] answers;
    private int index = 0;
    private bool canContinue;
    private int nextSceneToLoad;
    private int option;
    void Start()
    {
        for(int i=0;i< answers.Length;i++)
        {
            answers[i].SetActive(true);
        }
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {    

        
        if(canContinue && Input.GetMouseButtonDown(0))
        {
            index++;
            
            if (option==1 && dialogue1.Length > index)
            {
                dialoguePanel.SetActive(true);
                dialogueText.text = (dialogue1[index]);
            }
            else if (option == 2 && dialogue2.Length > index)
            {
                dialoguePanel.SetActive(true);
                dialogueText.text = (dialogue2[index]);
            }
            else
            {
                SceneManager.LoadScene(nextSceneToLoad);
            }
           

        }
        

    }

    public void Option1()
    {
        option = 1;
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        canContinue = true;
        dialoguePanel.SetActive(true);
        dialogueText.text = (dialogue1[index]);
        
        

        
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
       

        
    }
    


}