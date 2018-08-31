using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Collision_Tracker : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.rigidbody) 
		{
			Debug.Log ("Collision detected! Load new scene.");
            SceneManager.LoadSceneAsync("Retry");
		}
	}
}