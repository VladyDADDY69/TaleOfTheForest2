using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    private CapsuleCollider2D coll;
    private SpriteRenderer sprite;
    private Rigidbody2D rb;
    private float dirx = 0f;
    public float KBForce;
    public float KBCounter;
    public float KBTotalTime;
    public bool KnockFromRight;
    public bool isFacingRight;
    public Animator animator;

    [SerializeField] private LayerMask jumpableGround;
    // Start is called before the first frame update 

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
       

    }

    // Update is called once per frame 

    void FixedUpdate()
    {

        if (KBCounter <= 0)
        {
            rb.velocity = new Vector2(dirx, rb.velocity.y);
        }
        else
        {
            if (KnockFromRight == true)
            {
                rb.velocity = new Vector2(-KBForce, KBForce);
            }
            if (KnockFromRight == false)
            {
                rb.velocity = new Vector2(KBForce, KBForce);
            }
            KBCounter -= Time.deltaTime;
        }

        UpdateAnimationUpdate();
    }
    private void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(dirx));
        animator.SetFloat("speed1", Mathf.Abs(dirx));
        dirx = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && GC())
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isJumping1", true);
            rb.velocity = new Vector2(rb.velocity.x, 3.5f);

        }
        else
        {
            StartCoroutine(WaitForFunction());
            animator.SetBool("isJumping", false);
            animator.SetBool("isJumping1", false);
        }
    }
    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(4);

    }
    private void UpdateAnimationUpdate()
    {

        if (dirx > 0f)
        {
            sprite.flipX = false;
            isFacingRight = true;
            
        }

        else if (dirx < 0f)
        {
            sprite.flipX = true;
            isFacingRight = false;
            
        }

    }
    private bool GC()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}