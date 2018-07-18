using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    [SerializeField] int scoreDef = 5;
    [SerializeField] TextMeshProUGUI score;

    public static Score scoreManager;
    public int scoreAmount;

   void Awake()
    {
        scoreManager = this;
    }

	void Update () {

        score.text = scoreAmount.ToString();
    }

    public void AddScore()
    {
        scoreAmount = scoreAmount + scoreDef;
    }
}
