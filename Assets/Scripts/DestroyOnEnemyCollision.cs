using UnityEngine;

public class DestroyOnEnemyCollision : MonoBehaviour
{
    public GameObject waterSplash;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            var enemy = other.GetComponent<EnemyController>();
            enemy.health--;

            if (enemy.health == 0)
            {
                Destroy(other.gameObject);
            }
            
            Instantiate(waterSplash, other.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
