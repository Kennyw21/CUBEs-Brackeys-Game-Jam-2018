using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thank_You_Exit : MonoBehaviour {

    //Not required

    /*public GameObject panelThankYou;
    public GameObject panelPause;*/

	
	// Update is called once per frame
	void Update () {
        //The mouse cursor issue was not fixed by the commented code below

		/*if(panelPause.active==true)
        {
            panelThankYou.SetActive(false);
        }
        else
        {
            panelThankYou.SetActive(true);
        }*/

        if(Input.GetKeyDown(KeyCode.Escape)==true)
        {
            Application.Quit();
            Debug.Log("return 0;");
        }
	}
}
