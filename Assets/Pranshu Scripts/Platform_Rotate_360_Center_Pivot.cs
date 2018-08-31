using UnityEngine;
using System.Collections;

public class Platform_Rotate_360_Center_Pivot : MonoBehaviour {

	public int x=0;
	public int y=0;
	public int z=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (x*Time.deltaTime, y*Time.deltaTime, z*Time.deltaTime);
	}
}
