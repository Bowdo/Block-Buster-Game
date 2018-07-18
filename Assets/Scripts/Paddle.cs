using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidth = 16f;
    

	void Start () {
		
	}
	
	void Update () {
        float mouseX = Input.mousePosition.x / Screen.width * screenWidth;

        Debug.Log(mouseX);   // return a % instead of a pixel value. 1.0 to the far right, 0.0 to the left then * 16 to get screen units
        Vector2 paddlePos = new Vector2(mouseX, transform.position.y);
        transform.position = paddlePos;
    }
}
