﻿using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public int score;
    public int health;

    private GameController gameController;
    private float initialSpeed;

    void Start()
    {
        initialSpeed = speed;
        GameObject parentGameObject = GameObject.FindGameObjectWithTag("GameController");
        if (parentGameObject != null)
        {
            gameController = parentGameObject.GetComponent<GameController>();
        }

        if (gameController ==  null)
        {
            Debug.Log("GameController not found");
        }
    }

    void Update ()
    {
        if (!gameController.IsGameOver())
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    void OnDestroy()
    {
        gameController.AddToScore(score);

        var enemies = GameObject.FindGameObjectsWithTag("Enemy");

        Vector3 enemyPosition = gameObject.transform.position;
        foreach(GameObject enemy in enemies)
        {
            Vector3 otherPosition = enemy.transform.position;
            if (otherPosition.z > enemyPosition.z)
            {
                enemy.GetComponent<EnemyController>().ResetSpeed();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Flowers")
        {
            gameController.SetGameOver(true);
        }

        if (other.tag == "Enemy")
        {
            if (other.gameObject.transform.position.z < gameObject.transform.position.z)
            {
                speed = 0;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            if (other.gameObject.transform.position.z < gameObject.transform.position.z)
            {
                ResetSpeed();
            }
        }
    }

    void ResetSpeed()
    {
        speed = initialSpeed;
    }
}
