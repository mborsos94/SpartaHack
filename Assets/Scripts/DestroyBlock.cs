using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour {
        public GameObject[] brickParticles;
    private GameObject referenceObj;
	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ball"))
        {
            int particle;
            particle = UnityEngine.Random.Range(0, brickParticles.Length);
            brickParticles[particle].GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
            referenceObj = GameObject.FindGameObjectWithTag("Player");
            if(gameObject.GetComponent<SpriteRenderer>().color != Color.white )
            {
                referenceObj.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;
            }
            Instantiate(brickParticles[particle], transform.position, Quaternion.identity);
            GameObject.Destroy(gameObject);
        }
    }
}
