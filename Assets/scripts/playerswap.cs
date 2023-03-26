using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerswap : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject bg1;
    public GameObject bg2;
    public Transform subject1;
    public Transform subject2;
    public movement movement;
    public movement movement2;
    public bool player1Active = true;
    public bool bg1Active = true;


    float distanceFromPlayer => subject2.position.x - subject1.position.x;

    // Start is called before the first frame update
    void Start()
    {
        player2.SetActive(false);
        bg2.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SwapPlayer();
        }
    }
    public void SwapPlayer()
    {
        if (player1Active)
        {
            movement.enabled = false;
            movement2.enabled = true;
            player1Active = false;
            bg1Active = false;
            player1.SetActive(false);
            bg1.SetActive(false);
            player2.SetActive(true);
            bg2.SetActive(true);
            if (distanceFromPlayer != 0)
            {
                Vector2 newPos = subject1.position;
                subject2.position = new Vector2(newPos.x, newPos.y);
            }
        }
        else
        {
            movement.enabled = true;
            movement2.enabled = false;
            player1Active = true;
            bg1Active = true;
            player2.SetActive(false);
            bg2.SetActive(false);
            player1.SetActive(true);
            bg1.SetActive(true);
            if (distanceFromPlayer != 0)
            {
                Vector2 newPos = subject2.position;
                subject1.position = new Vector2(newPos.x, newPos.y);
            }
        }
    }
}
