using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu_Manager : MonoBehaviour {

    public AudioMixer audioMixer;

    public Dropdown resolution_Dropdown;
    Resolution[] resolution;

    //I have filled the resolution dropdown with all the system supported resolutions
    private void Start()
    {
        int currentResolutionIndex = 0;

        resolution = Screen.resolutions;
        List<string> resolutionList = new List<string>();
        resolution_Dropdown.ClearOptions();
        for (int i = 0; i < resolution.Length; i++)
        {
            string temp = resolution[i].width + " x " + resolution[i].height;
            resolutionList.Add(temp);

            if (Screen.currentResolution.height == resolution[i].height && Screen.currentResolution.width == resolution[i].width)
            {
                currentResolutionIndex = i;
            }

            resolution_Dropdown.RefreshShownValue();
        }

        resolution_Dropdown.value = currentResolutionIndex;
        resolution_Dropdown.AddOptions(resolutionList);
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution res = resolution[resolutionIndex];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }

    //Sets the fullscreen mode on or off...by default is on
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    //Sets the master volume level between -80dB and 20dB...by default 0dB
    public void SetVolume(float value)
    {
        audioMixer.SetFloat("Volume", value);
    }

    //Sets the game quality level...by default Fantastic/Ultra
    public void SetQuality(int qualityIndex)
    {
        switch (qualityIndex)
        {
            case 0:
                QualitySettings.SetQualityLevel(0);
                break;
            case 1:
                QualitySettings.SetQualityLevel(1);
                break;
            case 2:
                QualitySettings.SetQualityLevel(2);
                break;
            case 3:
                QualitySettings.SetQualityLevel(3);
                break;
            case 4:
                QualitySettings.SetQualityLevel(4);
                break;
            case 5:
                QualitySettings.SetQualityLevel(5);
                break;
        }
    }

    public void PlayNewGame()
    {
        SceneManager.LoadSceneAsync("Story_Scene_1");
    }
}
