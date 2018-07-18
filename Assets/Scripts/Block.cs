using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] Sprite[] sprites;
    private SpriteRenderer spriteR;
    private int spriteVersion = 0;
    

	void Start () {
        spriteR = gameObject.GetComponent<SpriteRenderer>();  
	}
	
	// Update is called once per frame
	void Update ()
    {
        SpriteHandler();
    }

    private void SpriteHandler()
    {
        if (spriteVersion == 0)
        {
            spriteR.sprite = sprites[spriteVersion];
        }
        if (spriteVersion == 1)
        {
            spriteR.sprite = sprites[spriteVersion];
        }
        if (spriteVersion == 2)
        {
            spriteR.sprite = sprites[spriteVersion];
        }
        if (spriteVersion == 3)
        {
            DestroyBox();
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        spriteVersion++;
        Debug.Log("Ball hit block");
      
    }
    void DestroyBox()
    {
        Destroy(gameObject);
        Debug.Log("Block Destroyed");

    }
}
