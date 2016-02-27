using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour {
        public GameObject[] brickParticles;
	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ball"))
        {
            int particle;
            particle = UnityEngine.Random.Range(0, brickParticles.Length);
            Instantiate(brickParticles[particle], transform.position, Quaternion.identity);
            GameObject.Destroy(gameObject);
        }
    }
}
