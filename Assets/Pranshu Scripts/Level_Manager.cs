using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour {

    //MAIN MENU
    public void LoadMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    //SKY HIGH
	public void LoadMainLevel()
    {
        SceneManager.LoadSceneAsync(1);
    }
    //IN DARKNESS
    public void LoadInDarkness()
    {
        SceneManager.LoadSceneAsync(3);
    }
    //FOREST STROLL
    public void LoadForestStroll()
    {
        SceneManager.LoadSceneAsync(5);
    }
    //NOTHING MAKES SENSE
    public void LoadNothingMakesSense()
    {
        SceneManager.LoadSceneAsync("Nothing_Makes_Sense");
    }

    //EXIT GAME
    public void QuitGame()
    {
        Application.Quit();
	}

    //LOAD NEXT LEVEL
    public void LoadNextLevel()
    {
        //This method will load the next scene in the build menu
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Will load the previous level if the retry scene was loaded
    public void LoadCurrentLevel()
    {
        int buildIndex = PlayerPrefs.GetInt("currentBuildIndex",0);
        SceneManager.LoadSceneAsync(buildIndex);
    }
    
}