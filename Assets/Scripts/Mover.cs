using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()// Running behind the scenes
    {
        
        MovePlayer();// Using methods like this makes your code more readable
    }

    void PrintInstructions()
    {//it is easy to see code block like this.
        Debug.Log("Welcome to the game");
        Debug.Log("Here are the instructions that are used to play game.");
        Debug.Log("Mr. Blinky");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!!!");

    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // it means +1 and -1 of x Axe
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }
}
