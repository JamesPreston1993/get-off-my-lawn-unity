using UnityEngine;

public class DestroyOnEnemyCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
