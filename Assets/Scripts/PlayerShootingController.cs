using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    public GameObject shot;
    public float shootRate;
    private float nextShot;

	void Update ()
    {
		if (Input.GetKey(KeyCode.Space) && Time.time > nextShot)
        {
            nextShot = Time.time + shootRate;
            Instantiate(shot, new Vector3
            {
                x = transform.position.x,
                y = transform.position.y,
                z = transform.position.z + 2
            }, Quaternion.identity);
        }
	}
}
