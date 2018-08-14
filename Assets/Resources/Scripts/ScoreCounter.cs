using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
	private int score;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateScore(int newScore)
	{
		score += newScore;
		GetComponent<TextMeshPro>().text = "Score: " + score.ToString();
	}
}
