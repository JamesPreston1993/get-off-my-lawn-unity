using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject neighbour;
    public GameObject salesman;
    public GameObject paperBoy;
    public float neighbourChance;
    public float salesmanChance;
    public float paperBoyChance;

    public SpawnRateModel spawnRate;
    public float xMin;
    public float xMax;
    
    private float nextSpawn;
    private float currentSpawnRate;
    private float nextIntervalUpdate;
    private int spawnCounter;
    private GameController gameController;

    void Start()
    {
        if ((float) neighbourChance + salesmanChance + paperBoyChance != 1.0)
        {
            Debug.Log("Spawn chances must total to 1.0");
        }

        currentSpawnRate = spawnRate.initialRate;
        nextIntervalUpdate =spawnRate.updateInterval;
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
        if (!gameController.IsGameOver())
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + currentSpawnRate;
                spawnCounter++;

                GameObject enemy;
                if (spawnCounter <= 10)
                {
                    enemy = neighbour;
                }
                else
                {
                    enemy = SpawnRandomEnemy();
                }
                
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
            if (Time.time > nextIntervalUpdate && currentSpawnRate >= 1.5)
            {
                nextIntervalUpdate = Time.time + spawnRate.updateInterval;
                currentSpawnRate -= spawnRate.updateAmount;
            }
        }
    }

    private GameObject SpawnRandomEnemy()
    {
        float randomNum = Mathf.Round(Random.value * 10f) / 10f;
        if (randomNum <= neighbourChance)
        {
            return neighbour;
        }
        else if (randomNum <= neighbourChance + salesmanChance)
        {
            return salesman;
        }
        else
        {
            return paperBoy;
        }
    }
}

[System.Serializable]
public class SpawnRateModel
{
    public float initialRate;
    public float updateInterval;
    public float updateAmount;
}
