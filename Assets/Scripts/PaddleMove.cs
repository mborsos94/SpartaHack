using UnityEngine;
using System.Collections;

public class PaddleMove : MonoBehaviour {
    public float paddleSpeed;
    public float minX;
    public float maxX;
    public float startXPos;

    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate () 
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 vel = body.velocity;
        vel.x = horizontal * paddleSpeed;
        body.velocity = vel;

        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minX + startXPos, maxX + startXPos);
        transform.position = pos;
	}
}
