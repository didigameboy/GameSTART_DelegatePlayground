using UnityEngine;
using System.Collections;
using System;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private GameObject playerPrefab;

    private GameObject currentPlayer;

    public delegate void DelPlayerKilled();
    public DelPlayerKilled delPlayerKilled;

    public delegate void DelPlayerSpawned();
    public DelPlayerSpawned delPlayerSpawned;

    public void Start()
    {
        Invoke("SpawnPlayer", 0.5f);
    }

    public void SpawnPlayer()
    {
        currentPlayer = Instantiate(playerPrefab);
        if (delPlayerSpawned!=null)
            delPlayerSpawned();
    }

    public void KillPlayer()
    {
        Destroy(currentPlayer);
        Invoke("SpawnPlayer", 2f);

        if (delPlayerKilled != null)
            delPlayerKilled();
    }

}
