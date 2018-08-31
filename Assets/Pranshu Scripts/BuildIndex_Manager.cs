using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildIndex_Manager : MonoBehaviour {

    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("currentBuildIndex", SceneManager.GetActiveScene().buildIndex);
	}
}
