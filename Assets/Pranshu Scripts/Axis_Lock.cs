using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis_Lock : MonoBehaviour {
    Rigidbody rb3d;
    public GameObject powerupEffect;
    int flag = 0;
    // Use this for initialization
    void Start () {
        rb3d = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        flag++;
        rb3d.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        if (flag == 1)
        {
            
            Instantiate(powerupEffect, transform.position, transform.rotation);
        }
    }
}
