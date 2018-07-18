using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    [SerializeField] int scoreDef = 5;
    [SerializeField] TextMeshProUGUI score;

    public int scoreAmount;

    void Start ()  {
		
	}
	
	void Update () {

        score.text = scoreAmount.ToString();
    }

    public int GetScoreAmount()
    {
        return scoreAmount;
    }

    public void AddScore()
    {
        scoreAmount = scoreAmount + scoreDef;
    }
}
