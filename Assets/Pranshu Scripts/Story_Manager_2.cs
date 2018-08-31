using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story_Manager_2 : MonoBehaviour {

    public Text story;
    private enum State { initial, t1, t2, final };
    private State current;

    private void Start()
    {
        current = State.initial;
    }

    // Update is called once per frame
    void Update()
    {
        switch (current)
        {
            case State.initial:
                Initial();
                break;
            case State.t1:
                Text1();
                break;
            case State.t2:
                Text2();
                break;
            case State.final:
                Final();
                break;
            default:
                ;
                break;
        }
    }

    public void Initial()
    {
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t1;
    }

    public void Text1()
    {
        story.text = "Who turned off the lights now?";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t2;
    }

    public void Text2()
    {
        story.text = ". . .";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.final;
    }

    public void Final()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
    }
}
