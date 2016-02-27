using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class LaunchBall : MonoBehaviour {
    public float startingSpeed;
    public int   angleFromVertical;

	void Update () {
        if (Input.GetButtonDown("Activate"))
        {
            // Pick out a random direction within constraints
            int maxAngle = 90 + angleFromVertical;
            int minAngle = 90 - angleFromVertical;
            float angle = Random.Range(minAngle, maxAngle);
            Vector2 velocity = new Vector2();
            velocity.x = Mathf.Cos(angle);
            velocity.y = -Mathf.Sin(angle);
            Rigidbody2D body = GetComponent<Rigidbody2D>();
            body.velocity = velocity * startingSpeed;

            GameObject.DestroyObject(this);
        }
	}
}
