using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {
    public GameObject[] bricks;
    public int minNumOfBricks;
	// Use this for initialization
	void Start () {
        RandomizeBricks();
	}

    void RandomizeBricks()
    {
        int randNum;
        int xpos = 0;
        int ypos = 0;
        int color = 0;
        int currNumOfBricks = bricks.Length;
        Color[] colors = {Color.red, Color.yellow, Color.white, Color.blue, Color.black, Color.green, Color.gray, Color.magenta};
            for (int i = 0; i < bricks.Length; i++)
            {
                    if(xpos == 10)
                    {
                        xpos = 0;
                        ypos = 0;
                    }
                    if(ypos == 5)
                    {
                        ypos = 0;
                        xpos++;
                    }
                    randNum = UnityEngine.Random.Range(0, 2);
                    if (randNum == 1 || currNumOfBricks == minNumOfBricks)
                    {
                        bricks[i].GetComponent<RectTransform>().transform.position = new Vector3(0.5f + xpos - 5, ypos, 0);
                        color = UnityEngine.Random.Range(0,colors.Length);
                        bricks[i].GetComponent<MeshRenderer>().material.color = colors[color];
                    }
                    else
                    {
                        Destroy(bricks[i]);
                        currNumOfBricks--;
                    }
                    ypos++;
                    
            }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
