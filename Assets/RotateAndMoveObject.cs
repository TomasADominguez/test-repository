using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndMoveObject : MonoBehaviour
{
    public int rotateSpeed = 9;
    public int moveSpeed = 5;



    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
    }
}
