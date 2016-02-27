using UnityEngine;
using System.Collections;

public class PaddlePowerUps : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        bool genPU = Input.GetButtonDown("Fire2");
        bool specPU = Input.GetButtonDown("Fire3");

        if (genPU)
            print("general");
        if (specPU)
            print("special");
    }
}
