using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 0.5f;
    [SerializeField] float yPush = 18f;
    bool hasStarted = false;

    Vector2 paddleToBallVector;

	void Start ()
    {
        paddleToBallVector = transform.position - paddle1.transform.position; // Balls pos - Paddles Pos for the offset
        
    }
	
	
	void Update ()
    {
        if (!hasStarted)
        {
            LaunchOnMouseClick();
            LockBallToPaddle();
        }
        
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStarted = true;
            Debug.Log(hasStarted);
            
        }

    }

    private void LockBallToPaddle()
    {
            Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
            transform.position = paddlePos + paddleToBallVector;
        
    }
}
