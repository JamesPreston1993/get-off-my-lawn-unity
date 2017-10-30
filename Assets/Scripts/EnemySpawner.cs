using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;
    public float xMin;
    public float xMax;

    private float nextSpawn;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            Vector3 position = new Vector3
            {
                x = Random.Range(-1 * xMax, xMax),
                y = transform.position.y,
                z = transform.position.z
            };
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
}
