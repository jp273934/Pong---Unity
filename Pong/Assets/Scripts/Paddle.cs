using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int moveSpeed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if(Input.GetKeyDown("up"))
        {
            Debug.Log("up was pressed");

            rb.linearVelocityY += moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown("down"))
        {
            rb.linearVelocityY -= moveSpeed * Time.deltaTime;
        }

        if(Input.GetKeyUp("up") || Input.GetKeyUp("down"))
        {
            rb.linearVelocityY = rb.linearVelocityY;
        }
    }
}
 