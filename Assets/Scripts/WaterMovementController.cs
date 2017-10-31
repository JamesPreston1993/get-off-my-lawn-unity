using UnityEngine;

public class WaterMovementController : MonoBehaviour
{
    public float speed;
    private GameController gameController;

    void Start()
    {
        GameObject parentGameObject = GameObject.FindGameObjectWithTag("GameController");
        if (parentGameObject != null)
        {
            gameController = parentGameObject.GetComponent<GameController>();
        }

        if (gameController == null)
        {
            Debug.Log("GameController not found");
        }
    }

    void Update () {
        if (!gameController.IsGameOver())
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
