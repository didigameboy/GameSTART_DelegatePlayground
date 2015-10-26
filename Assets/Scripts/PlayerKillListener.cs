using UnityEngine;
using System.Collections;
using System;

public class PlayerKillListener : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;

    public void OnEnable()
    {
        gameController.delPlayerKilled += OnPlayerKilled;
    }

    public void OnDisable()
    {
        gameController.delPlayerKilled -= OnPlayerKilled;
    }

    private void OnPlayerKilled()
    {
        Debug.Log(string.Format("[1] Objeto <{0}> detectou PlayerKilled", name));
    }
}
