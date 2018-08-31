using UnityEngine;
using System.Collections;

public class Music_Manager : MonoBehaviour {
	static Music_Manager instance=null;
	void Awake()
	{
		if (instance != null)
			Destroy (gameObject);
		else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
}
