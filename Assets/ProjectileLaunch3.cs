using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLaunch3 : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchPoint;

    public float shootTime;
    public float shootCounter;
    public movement direction;
    // Start is called before the first frame update
    void Start()
    {
        shootCounter = shootTime;
        direction = GetComponent<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!direction.isFacingRight)
        {
            if (Input.GetButtonDown("Fire1") && shootCounter <= 0)
            {
                Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
                shootCounter = shootTime;
            }
        }
        shootCounter -= Time.deltaTime;
    }
}
