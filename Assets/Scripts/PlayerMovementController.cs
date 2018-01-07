using UnityEngine;
using Movement;

public class PlayerMovementController : MonoBehaviour
{
    public float speed;
    public Boundary boundary;

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

    void Update ()
    {
        if (gameController.IsGameOver())
        {
            return;
        }

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector3
        {
            x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax),
            y = transform.position.y,
            z = transform.position.z
        };
    }
}
