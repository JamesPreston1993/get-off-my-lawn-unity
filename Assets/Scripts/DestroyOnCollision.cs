using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Water")
        {
            Destroy(other.gameObject);
        }
    }
}
