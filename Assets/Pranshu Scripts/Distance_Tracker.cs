using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Distance_Tracker : MonoBehaviour {

	//CALCULATES SCORE BASED ON DISTANCE TRAVELED

	public int distance;
	public int score = 0;
	public int current_score;
	public GameObject Reference;
	public GameObject Player;
	public Text scoreText;

	void Update () {
		distance = (int)Reference.transform.position.x + (int)Player.transform.position.x + 1;
		current_score = distance / 5;

		if (current_score > score) {
			score = current_score;
			PlayerPrefs.SetInt ("Current_Score", current_score);
			if(score>PlayerPrefs.GetInt("Score",0))
				PlayerPrefs.SetInt ("Score", score);
			scoreText.text = score.ToString ();

		}
	}
}
