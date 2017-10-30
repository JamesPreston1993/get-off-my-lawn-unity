using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;
    public float xMin;
    public float xMax;

    private float nextSpawn;
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

    void Update()
    {
        if (!gameController.IsGameOver() && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            Vector3 position = new Vector3
            {
                x = Random.Range(xMin, xMax),
                y = transform.position.y,
                z = transform.position.z
            };
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
}
