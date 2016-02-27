using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class refreshServerButton : MonoBehaviour {

    public GameObject ButtonTemplate;
    private bool refreshingHostList = false;
    private string gameTypeName = "Breakout";

    public void RefreshServerList()
    {
        if (!refreshingHostList)
        {
            refreshingHostList = true;
            MasterServer.ClearHostList();
            MasterServer.RequestHostList(gameTypeName);
        }
    }

    private void JoinServer(HostData hostData)
    {
        Network.Connect(hostData);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (MasterServer.PollHostList().Length != 0)
        {
            HostData[] hostList = MasterServer.PollHostList();
            Debug.Log("here");
            for (int i = 0; i < hostList.Length; i++)
            {
                Debug.Log(hostList[i].gameName);
                GameObject serverScrollViewObject = GameObject.Find("serverScrollView");
                ScrollRect serverScrollViewRect = serverScrollViewObject.GetComponent<ScrollRect>();
            }
            MasterServer.ClearHostList();
        }
	}
    
}
