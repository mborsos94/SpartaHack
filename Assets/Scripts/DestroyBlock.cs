using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ball"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}
