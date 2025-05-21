using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int moveSpeed = 500;

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

            rb.AddForce(Vector2.up * moveSpeed, ForceMode2D.Force);
        }

        if (Input.GetKeyDown("down"))
        {
            rb.AddForce(Vector2.down *  moveSpeed, ForceMode2D.Force);
        }

        if(Input.GetKeyUp("up") || Input.GetKeyUp("down"))
        {
            rb.linearVelocityY = 0;
        }
    }
}
  