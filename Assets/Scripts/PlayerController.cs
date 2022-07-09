using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalMove;
    private float verticalMove;
    private CharacterController player;
    [Range(2, 10)]
    [HideInInspector] public int playerSpeed = 5;
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        verticalMove = Input.GetAxis("Vertical");

        Run();
    }

    void Run()
    {
        Vector3 movement= new Vector3(horizontalMove, 0, verticalMove);

        player.Move(movement * playerSpeed * Time.deltaTime);
    }

}
