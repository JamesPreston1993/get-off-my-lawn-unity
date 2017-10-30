using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public float score;

    private GameController gameController;

    void Start()
    {
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
		transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void OnDestroy()
    {
        gameController.AddToScore(10);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Flowers")
        {
            gameController.SetGameOver(true);
        }
    }
}
