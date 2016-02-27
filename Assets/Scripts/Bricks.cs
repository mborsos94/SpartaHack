using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {
    GameObject[] bricks = new GameObject[72];
    public GameObject brick;
    public Color[] powerUps;
    public int minNumOfBricks;
    public float startXPos;
	// Use this for initialization
	void Start () {
        CreateBricks();
        RandomizeBricks();
	}

    void CreateBricks()
    {
        for(int i = 0; i < 72; i++)
        {
            bricks[i] = Instantiate(brick);
        }
    }

    void RandomizeBricks()
    {
        int randNum;
        int xpos = 0;
        int ypos = 0;
        int color = 0;
        int currNumOfBricks = bricks.Length;
        int powerUp = 0;
        Color[] colors = {Color.red, Color.yellow, Color.white, Color.blue, Color.black, Color.green, Color.gray, Color.magenta};
            for (int i = 0; i < bricks.Length; i++)
            {
                    if(xpos == 11)
                    {
                        xpos = 0;
                        ypos = 0;
                    }
                    if(ypos == 6)
                    {
                        ypos = 0;
                        xpos++;
                    }
                    randNum = UnityEngine.Random.Range(0, 2);
                    if (randNum == 1 || currNumOfBricks == minNumOfBricks)
                    {
                        bricks[i].GetComponent<RectTransform>().transform.position = new Vector3(0.5f + startXPos + xpos - 5, ypos - 0.5f, 0);
                        color = UnityEngine.Random.Range(0,colors.Length);
                        bricks[i].GetComponent<MeshRenderer>().material.color = colors[color];
                        if( UnityEngine.Random.Range(0,72) % 2 == 0 )
                        {
                            powerUp = UnityEngine.Random.Range(0, powerUps.Length);
                            {
                                bricks[i].GetComponent<Light>().color = powerUps[powerUp];
                                bricks[i].GetComponent<Light>().intensity = 15;
                            }
                        }
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
