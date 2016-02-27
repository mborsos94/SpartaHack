using UnityEngine;
using System.Collections;

public class BrickSpawner : MonoBehaviour {
    public int verticalSpan;
    public int horizontalSpan;

    public float verticalSpacing;
    public float horizontalSpacing;

    public float spawnChance;
    public GameObject brickPrefab;

    public float powerUpChance;

    Color[] colors = { Color.red, Color.yellow, Color.white, Color.blue, Color.green, Color.gray, Color.magenta };

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
                    float rand2 = Random.value;
                    if (rand2 < powerUpChance)
                    {
                        int rand3 = Random.Range(0, colors.Length);
                        obj.GetComponent<SpriteRenderer>().color = colors[rand3];
                    }
                    obj.transform.parent = transform;
                }
            }
        }
	}
}
