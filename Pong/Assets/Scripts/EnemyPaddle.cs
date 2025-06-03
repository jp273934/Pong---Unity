using UnityEngine;

public class EnemyPaddle : MonoBehaviour
{
    public int moveSpeed = 100;
    public Transform ball;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.y > transform.position.y)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        if (ball.position.y < transform.position.y)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }


    }
}
