using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {
	public float Speed=200f;
	public float MaxSpeed=100f;
	public float JumpPower=100f;
	private Rigidbody rb3d;
	void Awake(){
		rb3d = gameObject.GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		float H = Input.GetAxis ("Horizontal");
		rb3d.AddForce ((Vector3.right * Speed) * H);
		if (H * rb3d.velocity.x < MaxSpeed) {
			rb3d.AddForce ((Vector3.right * Speed) * H);
		}
		if (Mathf.Abs (rb3d.velocity.x) > MaxSpeed) {
			rb3d.AddForce ((Vector3.left * Speed) * H);
		}
		float V = Input.GetAxis ("Vertical");
		if(V!=0)
			rb3d.AddForce ((Vector3.up * JumpPower)*V);
	}

}