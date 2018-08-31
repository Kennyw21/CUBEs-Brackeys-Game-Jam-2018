using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_Menu_Manager : MonoBehaviour {

    bool pauseStatus;

    //use this variable to defined your own timeScale value (float)[0,1], use this for slow-mo effects
    public float TimeScale = 0f;

    //PauseMenu Background
    public GameObject pausePanel;
    //Cursor_Manager
    public GameObject cursorObject;

	// Use this for initialization
	void Start () {
        pauseStatus = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseStatus == false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
	}

    //Will set the timeScale to a defined value
    void Pause()
    {
        {
            //pausePanel
            pausePanel.SetActive(true);
            cursorObject.SetActive(false);
            Cursor.visible = true;
        }
        pauseStatus = true;
        Time.timeScale = TimeScale;
    }

    //Will set the timeScale to 1
    public void Resume()
    {
        {
            //pausePanel
            pausePanel.SetActive(false);
            cursorObject.SetActive(true);
            Cursor.visible = false;
        }
        pauseStatus = false;
        Time.timeScale = 1.0f;
    }
}
