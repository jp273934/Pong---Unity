using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScore;
    public int EnemyScore;
    public Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerScore = 0;
        EnemyScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyScored()
    {
        Debug.Log("Enemy Scored !!!");
        var ball = GameObject.Find("Ball");

        EnemyScore++;

       ball.transform.position = spawnPoint.position;
       
       var ballObject = ball.GetComponent<Ball>();
        ballObject.RestartBall();
    }

    public void PlayerScored()
    {
        Debug.Log("Player Scored !!!");
        var ball = GameObject.Find("Ball");

        PlayerScore++;

        ball.transform.position = spawnPoint.position;

        var ballObject = ball.GetComponent<Ball>();
        ballObject.RestartBall();
    }
}
