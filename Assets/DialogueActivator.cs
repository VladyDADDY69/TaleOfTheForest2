using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour
{   
    [SerializeField]
    private GameObject dialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        dialogueManager.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
