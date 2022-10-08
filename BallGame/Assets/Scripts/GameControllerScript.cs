using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public float SpawnTime;
    public GameObject ball;
    float m_spawnTime;

    int m_score;
    bool m_isGameOver;

    private void Start()
    {
        m_spawnTime = 0; 
        m_isGameOver = false;
    }

    private void Update()
    {
        m_spawnTime -= Time.deltaTime;

        if (m_isGameOver)
        {
            m_spawnTime = 0;
            return;
        }

        if (m_spawnTime <= 0)
        {
            SpawnBall();

            m_spawnTime = SpawnTime;
        }
    }

    public void SpawnBall()
    {
        Vector2 ballPosition = new Vector2(Random.Range(-9, 9), 4);

        if (ball)
        {
            Instantiate(ball, ballPosition, Quaternion.identity);
        }
    }

    public void setScore(int score)
    {
        this.m_score = score;
    }

    public int getScore() { return this.m_score; }
    public void IncreaseScore()
    {
        this.m_score++;
    }

    public void setGameOver(bool isGO)
    {
        this.m_isGameOver = isGO;
    }

    public bool isGameOver()
    {
        return this.m_isGameOver;
    }
}
