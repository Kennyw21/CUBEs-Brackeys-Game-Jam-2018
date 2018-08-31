using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Time_Manager : MonoBehaviour {
	public Text timeText;
	private float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f0");
		timeText.text = minutes + " , " + seconds;
		PlayerPrefs.SetString ("Time", timeText.text);
	}
}
