using UnityEngine;
using System.Collections;

public class BrickCollider : MonoBehaviour {
    public GameObject[] brickParticles;
	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        int particle;
        particle = UnityEngine.Random.Range(0, brickParticles.Length);
        Instantiate(brickParticles[particle], transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
