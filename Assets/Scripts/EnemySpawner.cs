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
                y = 0.01f,
                z = transform.position.z
            };
            Instantiate(enemy, position, new Quaternion
            {
                x = 0.0f,
                y = 180.0f,
                z = 0.0f
            });
        }
    }
}
