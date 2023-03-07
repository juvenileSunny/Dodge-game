using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }


    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed *Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed *Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }

}
