using UnityEngine;
using System.Collections;

public class PlayerSpawnListener : MonoBehaviour {

    [SerializeField]
    private GameController gameController;

    public void OnEnable()
    {
        gameController.delPlayerSpawned += OnPlayerSpawned;
    }

    public void OnDisable()
    {
        gameController.delPlayerSpawned -= OnPlayerSpawned;
    }

    private void OnPlayerSpawned()
    {
        Debug.Log(string.Format("Objeto {0} detectou PlayerSpawned", name));
    }

}
