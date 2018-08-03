using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftWall : MonoBehaviour {

    [SerializeField] Rigidbody2D ball;

    void OnCollisionEnter2D(Collision2D other)
    {
         float xDistance = ball.position.x - transform.position.x;
         int random = Random.Range(1, 11);
         ball.AddForce(transform.forward * 18);

        if (random <= 5)
        {
            ball.AddForce(transform.forward * 18);
            ball.velocity = new Vector2(ball.velocity.x, ball.velocity.y + -5);
            Debug.Log("Left Wall: " + random);
        }
        else
        {
            ball.AddForce(transform.forward * 18);
            ball.velocity = new Vector2(ball.velocity.x, ball.velocity.y + 5);
            Debug.Log("Left Wall: " + random);
        }

    }
}
