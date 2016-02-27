using UnityEngine;
using System.Collections;

public class BallRespawn : MonoBehaviour {
    public GameObject ballPrefab;
    public float yOffset;

    public float respawnTime;

    private GameObject player;
    private bool respawning;
    private float respawnMark;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        respawnMark = Time.time - respawnTime;
        respawning = false;
	}
	
	void Update () {
        if (respawning && Time.time - respawnTime > respawnMark)
        {
            Vector2 pos = player.transform.position;
            pos.y += yOffset;
            GameObject.Instantiate(ballPrefab, pos, Quaternion.identity);
            respawning = false;
        }

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            GameObject.Destroy(other.gameObject);
            respawnMark = Time.time;
            respawning = true;
        }
    }
}
