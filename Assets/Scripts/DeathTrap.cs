using UnityEngine;
using System.Collections;

public class DeathTrap : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameController.KillPlayer();
        }
    }
}
