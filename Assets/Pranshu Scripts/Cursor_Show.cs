using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_Show : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Cursor.visible == false)
        {
            SetVisible();
        }
	}

    public void SetVisible()
    {
        Cursor.visible = true;
    }
}
