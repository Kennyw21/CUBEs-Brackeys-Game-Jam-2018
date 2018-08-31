using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story_Manager_1 : MonoBehaviour {

    public Text story;
    private enum State { initial, t1, t2, t3, t4, t5, t6, t7, t8, t9, final };
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
            case State.t3:
                Text3();
                break;
            case State.t4:
                Text4();
                break;
            case State.t5:
                Text5();
                break;
            case State.t6:
                Text6();
                break;
            case State.t7:
                Text7();
                break;
            case State.t8:
                Text8();
                break;
            case State.t9:
                Text9();
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
        if (Input.GetKeyDown(KeyCode.Return) == true)
            current = State.t1;
    }

    public void Text1()
    {
        story.text = "Where am i?";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t2;
    }
    public void Text2()
    {
        story.text = "What is this place?";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t3;
    }
    public void Text3()
    {
        story.text = "Who am i?";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t4;
    }
    public void Text4()
    {
        story.text = "What am i?";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t5;
    }
    public void Text5()
    {
        story.text = "These thoughts prevailed in my head as i woke up. It was a bizzare dream.";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t6;
    }
    public void Text6()
    {
        story.text = "It was all white and square and things...";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t7;
    }
    public void Text7()
    {
        story.text = "Hey, what is that?";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t8;
    }
    public void Text8()
    {
        story.text = "I see something red...";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.t9;
    }
    public void Text9()
    {
        story.text = ". . .";
        if (Input.GetKeyDown(KeyCode.Return) == true || Input.GetKeyDown(KeyCode.KeypadEnter) == true)
            current = State.final;
    }

    public void Final()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
