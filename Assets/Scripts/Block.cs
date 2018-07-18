using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : MonoBehaviour {

    [SerializeField] Sprite[] sprites;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] int scoreDef;

    private SpriteRenderer spriteR;
    private int spriteVersion = 0;
    private int scoreAmount;
    
	void Start () {
        spriteR = gameObject.GetComponent<SpriteRenderer>();  
	}
	
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
        scoreAmount = scoreAmount + scoreDef;
        AddScore();
    }

    void DestroyBox()
    {
        Destroy(gameObject);
        Debug.Log("Block Destroyed");
    }

    void AddScore()
    {
        score.text = scoreAmount.ToString();
    }
}
