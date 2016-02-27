using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class createRoomButton : MonoBehaviour {
    private string gameTypeName = "Breakout";
    
    public void StartServer()
    {
        GameObject nameInputField = GameObject.Find("roomNameInput");
        InputField nameInputFieldCo = nameInputField.GetComponent<InputField>();
        GameObject passwordInputField = GameObject.Find("passwordInput");
        InputField passwordInputFieldCo = nameInputField.GetComponent<InputField>();
        Network.incomingPassword = passwordInputFieldCo.text;
        Network.InitializeServer(5, 25000, !Network.HavePublicAddress());
        MasterServer.RegisterHost(gameTypeName, nameInputFieldCo.text);
        Debug.Log(nameInputFieldCo.text + gameTypeName);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
