using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement2 : MonoBehaviour
{
    public Transform playerTransform2;
    public bool isChasing2;
    public float chaseDistance2;
    public float moveSpeed2;

    public int mvsp2 = 1;
    private MonsterDamage hop2;
    public MonsterMovement monsterMovement;

    // Start is called before the first frame update
    void Start()
    {
        hop2 = GetComponent<MonsterDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing2)
        {
            if (hop2.hpPlayer <= 0)
            {
                mvsp2 = 0;
            }
            if (transform.position.x > playerTransform2.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
                transform.position += Vector3.left * moveSpeed2 * Time.deltaTime * mvsp2;
            }
            if (transform.position.x < playerTransform2.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position += Vector3.right * moveSpeed2 * Time.deltaTime * mvsp2;
            }
        }
        else
        {
            if (Vector2.Distance(transform.position, playerTransform2.position) < chaseDistance2)
            {
                isChasing2 = true;
            }
            else
            {
                isChasing2 = false;
            }
        }
    }
}

