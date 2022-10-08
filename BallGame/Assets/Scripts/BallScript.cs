using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    GameControllerScript m_gc;

    private void Start()
    {
        m_gc = FindObjectOfType<GameControllerScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_gc.IncreaseScore();
            Destroy(gameObject);

            Debug.Log("Point++");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathZone"))
        {
            m_gc.setGameOver(true);
            Destroy(gameObject);

            Debug.Log("GameOver");
        }
    }
}
