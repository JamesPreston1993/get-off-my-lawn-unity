using UnityEngine;

public class DestroyOnEnemyCollision : MonoBehaviour
{
    public GameObject waterSplash;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Water collision:" + other.tag);
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(waterSplash, other.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
