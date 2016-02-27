using UnityEngine;
using System.Collections;

public class PlayerConnect : MonoBehaviour {

    private int playerCount = 0;
    void OnPlayerConnected(NetworkPlayer player)
    {
        Debug.Log("Player " + playerCount++ + " connected from " + player.ipAddress + ":" + player.port);
    }
}
