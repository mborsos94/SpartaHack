using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class createRoomButton : MonoBehaviour {
    private string gameTypeName = "Breakout";
    
    public void StartServer()
    {
        GameObject nameInputField = GameObject.Find("roomNameInput");
        InputField nameInputFieldCo = nameInputField.GetComponent<InputField>();
        Network.InitializeServer(5, 25000, false);
        MasterServer.RegisterHost(gameTypeName, nameInputFieldCo.text);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
