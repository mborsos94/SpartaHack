using UnityEngine;
using System.Collections;

public class BrickSpawner : MonoBehaviour {
    public int verticalSpan;
    public int horizontalSpan;

    public float verticalSpacing;
    public float horizontalSpacing;

    public float spawnChance;
    public GameObject brickPrefab;

	void Start () 
    {
        for (int i = -verticalSpan; i <= verticalSpan; i++)
        {
            for (int j = -horizontalSpan; j <= horizontalSpan; j++)
            {
                float rand = Random.value;
                if (rand < spawnChance)
                {
                    Vector2 brickPosition = new Vector2();
                    brickPosition.x = j * horizontalSpacing;
                    brickPosition.y = i * verticalSpacing;
                    GameObject obj = (GameObject)GameObject.Instantiate(brickPrefab, brickPosition, Quaternion.identity);
                    obj.transform.parent = transform;
                }
            }
        }
	}
}
