using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidth = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] Rigidbody2D ball;

	void Start () {
	
	}
	
	void Update () {

        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidth;

        Vector2 paddlePos = new Vector2(mousePosInUnits, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);

        transform.position = paddlePos;
  //      Debug.Log(mousePosInUnits);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        ball.AddForce(transform.forward * 18);
    }
}
