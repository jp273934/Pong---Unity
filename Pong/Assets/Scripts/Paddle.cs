using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int moveSpeed = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey("up"))
        {
            Debug.Log("up was pressed");

           
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey("down"))
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }

        if(Input.GetKeyUp("up") || Input.GetKeyUp("down"))
        {
            //rb.linearVelocityY = 0;
        }
    }
}
  