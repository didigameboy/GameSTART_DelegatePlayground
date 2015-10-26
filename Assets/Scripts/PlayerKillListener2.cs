using UnityEngine;
using System.Collections;

public class PlayerKillListener2 : MonoBehaviour {

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
        Debug.Log(string.Format("[2] Objeto <{0}> detectou PlayerKilled", name));
    }

}
