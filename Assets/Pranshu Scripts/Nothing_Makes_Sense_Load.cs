using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nothing_Makes_Sense_Load : MonoBehaviour {

    public float delayAmount=100.0f;
    public  float rate = 1.0f;
    public bool flag = false;

    public GameObject triggerObj;
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(triggerObj);
        flag = true;
    }

    private void Update()
    {
        LoadNext();
    }

    //FIX THE CODE
    void LoadNext()
    {
        if(flag==true)
            delayAmount = delayAmount - (60.0f * Time.deltaTime) * rate;
        if (delayAmount <= 0)
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
