using UnityEngine;

public class Ball : MonoBehaviour
{
    public int moveSpeed = 500;

    private Rigidbody2D rb;
    private Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(Vector2.left * moveSpeed * Time.deltaTime, ForceMode2D.Force);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.linearVelocity = direction * moveSpeed * Time.deltaTime;
    }

    
}


