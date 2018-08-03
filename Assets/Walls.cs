using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {

    [SerializeField] Rigidbody2D ball; 


    void OnCollisionEnter2D(Collision2D other)
    {
        int random = Random.Range(1, 11);
        float xDistance = ball.position.x - transform.position.x;

        if(random <= 5)
        {
            ball.AddForce(transform.forward * 18);
            ball.velocity = new Vector2(-ball.velocity.x + xDistance - Random.Range(-2, 3), ball.velocity.y);
            Debug.Log(random);
        }
        else
        {
            ball.AddForce(transform.forward * 18);
            ball.velocity = new Vector2(ball.velocity.x + xDistance - Random.Range(-2, 3), ball.velocity.y);
            Debug.Log(random);
        }
        
    }

}
