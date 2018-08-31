using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore_Manager : MonoBehaviour {

	public int HighScore,CurrentScore;
	public Text ScoreText;
	public Text TimeText;
	public Text CurrentScoreText;
	// Use this for initialization
	void Start () {
		HighScore=PlayerPrefs.GetInt ("Score",0);
		CurrentScore = PlayerPrefs.GetInt ("Current_Score", 0);

		if (CurrentScore > HighScore)
			HighScore = CurrentScore;
		
		ScoreText.text = "Highscore - " + HighScore.ToString ();
		TimeText.text = "Time - " + PlayerPrefs.GetString ("Time","Time - XX");
		CurrentScoreText.text = "Score - " + PlayerPrefs.GetInt ("Current_Score", 0);
	}
}