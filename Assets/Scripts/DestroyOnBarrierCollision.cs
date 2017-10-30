using UnityEngine;

public class DestroyOnBarrierCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Water")
        {
            Destroy(other.gameObject);
        }
    }
}
