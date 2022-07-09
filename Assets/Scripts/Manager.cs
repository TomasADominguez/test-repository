using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;

    public void ChangeSpeed(bool active)
    {
        if (active)
        {
            playerController.playerSpeed++;
            
        }

        else
        {
            playerController.playerSpeed--;
            
        }
    }
}
