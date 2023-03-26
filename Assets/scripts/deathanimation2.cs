using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathanimation2 : MonoBehaviour
{
    private PlayerHealth hp;
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        hp = GetComponent<PlayerHealth>();
    }
    void Update()
    {
        
    }
    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("Mole"))
        {
            Die();
        }
    }

    private void Die()
    {
        GameObject.Find("Player").GetComponent<playerswap>().enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death1");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
