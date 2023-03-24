using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NpcDialogue : MonoBehaviour
{
    public string[] dialogue1;
    public string[] dialogue2;
    public TextMeshProUGUI dialogueText;
    public GameObject[] answers;
    private int nextSceneToLoad;
    private int k;
    public int numberOfSentences;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (k == numberOfSentences)
        {
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
        dialogueText.text = (dialogue1[0]);
    }
    public void Option2()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].SetActive(false);
        }
        dialogueText.text = (dialogue2[0]);
    }
}
