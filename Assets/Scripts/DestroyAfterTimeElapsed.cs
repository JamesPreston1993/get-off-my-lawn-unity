using UnityEngine;

public class DestroyAfterTimeElapsed : MonoBehaviour
{
    public float timeToLive;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update ()
    {
	    if (Time.time > startTime + timeToLive)
        {
            Destroy(gameObject);
        }
	}
}
