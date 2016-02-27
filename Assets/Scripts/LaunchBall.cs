﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class LaunchBall : MonoBehaviour {
    public float startingSpeed;
    public int   angleFromVertical;
    public AudioClip clip;
    AudioSource source;

    private GameObject referenceObj;

    void Start()
    {
        referenceObj = GameObject.FindGameObjectWithTag("Player");
        source = GameObject.Find("SFXSource").GetComponent<AudioSource>();
    }

	void Update () {
        if (Input.GetButtonDown("Activate"))
        {
            // Pick out a random direction within constraints
            int minAngle = 90 - angleFromVertical;
            int maxAngle = 90 + angleFromVertical;
            float angle = Random.Range(minAngle, maxAngle);
            Vector2 velocity = new Vector2();
            velocity.x = Mathf.Cos(angle);
            velocity.y = -Mathf.Sin(angle);
            Rigidbody2D body = GetComponent<Rigidbody2D>();
            body.velocity = velocity * startingSpeed;

            Debug.DrawRay(transform.position, transform.position + Quaternion.Euler(0.0f, 0.0f, minAngle) * Vector3.up);
            Debug.DrawRay(transform.position, transform.position + Quaternion.Euler(0.0f, 0.0f, maxAngle) * Vector3.up);

            GameObject.DestroyObject(this);
            source.PlayOneShot(clip);
        }
        else
        {
            Vector2 ballPos = transform.position;
            ballPos.x = referenceObj.transform.position.x;
            transform.position = ballPos;
        }
	}
}
