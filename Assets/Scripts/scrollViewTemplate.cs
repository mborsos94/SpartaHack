using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class scrollViewTemplate : MonoBehaviour
{

    public GameObject Button_Template;
    private List<string> NameList = new List<string>();
    private string gameTypeName = "Breakout";

    // Use this for initialization
    void Start()
    {

    }

    void JoinServer(HostData hostData)
    {
        Network.Connect(hostData);
        Debug.Log("Connected!");
    }

    public void ButtonClicked(string str)
    {
        Debug.Log(str + " button clicked.");
    }

    public void UpdateServerList()
    {
        MasterServer.RequestHostList(gameTypeName);
        if (MasterServer.PollHostList().Length != 0)
        {
            HostData[] hostList = MasterServer.PollHostList();
            for (int i = 0; i < hostList.Length; i++)
            {
                GameObject go = Instantiate(Button_Template) as GameObject;
                go.SetActive(true);
                scrollViewButtonTemplate TB = go.GetComponent<scrollViewButtonTemplate>();
                TB.SetName(hostList[i].gameName);
                go.transform.SetParent(Button_Template.transform.parent);
                Button_Template.GetComponent<Button>().onClick.AddListener(delegate {JoinServer(hostList[i]);});
            }
        }
        MasterServer.ClearHostList();
    }
}