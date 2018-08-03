using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

     [SerializeField] Sprite[] sprites;
     [SerializeField] Rigidbody2D ballRigid;
           float thrust = -18f;
           SpriteRenderer spriteR;
           int spriteVersion = 0;

	void Start ()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();  
	}
	
	void Update ()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        spriteVersion++;
        ballRigid.AddForce(transform.forward * thrust);
      //  ballRigid.AddTorque(0.5f);
        Debug.Log("Collision Detected");

        if (spriteVersion >= 3)
        {
            DestroyBox();
            Score.scoreManager.AddScore();
        }
        else
        {
            Score.scoreManager.AddScore();
            spriteR.sprite = sprites[spriteVersion];
            Debug.Log("Ball hit block");
        }

    }

    void DestroyBox()
    {
        Destroy(gameObject);
        Debug.Log("Block Destroyed");
    }

}
