using UnityEngine;
using System.Collections;

public class BallHit : MonoBehaviour {
    public AudioSource source;
    public AudioClip ballHit;
	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        source.PlayOneShot(ballHit);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
