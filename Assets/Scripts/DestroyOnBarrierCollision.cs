using System.Collections;
using System.Collections.Generic;
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
