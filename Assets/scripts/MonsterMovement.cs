using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;
    public float moveSpeed;
    public MonsterMovement2 monsterMovement2;
    public int mvsp = 1;
    private MonsterDamage hop;

    // Start is called before the first frame update
    void Start()
    {
        hop = GetComponent<MonsterDamage>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {

            if (hop.hpPlayer <= 0)
            {
                mvsp = 0;
            }
            if (transform.position.x > playerTransform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                transform.position += Vector3.left * moveSpeed * Time.deltaTime * mvsp;
            }
            if (transform.position.x < playerTransform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position += Vector3.right * moveSpeed * Time.deltaTime * mvsp;
            }
        }
        else
        {
            if (Vector2.Distance(transform.position, playerTransform.position) < chaseDistance)
            {
                isChasing = true;
            }
            else
            {
                isChasing = false;
            }
        }
    }
}
