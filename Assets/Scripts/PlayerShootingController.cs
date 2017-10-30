using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    public GameObject shot;
    public float shootRate;
    private float nextShot;

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

		if (Input.GetKey(KeyCode.Space) && Time.time > nextShot)
        {
            nextShot = Time.time + shootRate;
            Instantiate(shot, new Vector3
            {
                x = transform.position.x,
                y = transform.position.y,
                z = transform.position.z + 2
            }, Quaternion.identity);
        }
	}
}
