using UnityEngine;
using System.Collections;

public class Invader : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;

    public void Start()
    {
        InvokeRepeating("Tick", 1f, 2f);
    }

    void Tick()
    {
        gameController.delPlayerKilled();
    }
}
