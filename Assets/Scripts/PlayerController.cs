using UnityEngine;
using Movement;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Boundary boundary;
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        transform.position = new Vector3
        {
            x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax),
            y = transform.position.y,
            z = transform.position.z
        };
    }
}
