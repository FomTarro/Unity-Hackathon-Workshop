using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	public float speed = 0.1f;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		//Find the Rigidbody component in our cube
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
 		//Get input values from Unity's Input Manager
		///	Unity's Horizontal by default are the left/right arrow keys, and A/D keys
		float horizontal = Input.GetAxis("Horizontal");
		/// Unity's Vertical by default are the up/down arrow keys, and W/S keys
		float vertical = Input.GetAxis("Vertical");

		//Give the Rigidbody a velocity of the direction we are going at times a speed
		rb.AddForce(new Vector3(horizontal, 0, vertical) * speed);
	}
}

