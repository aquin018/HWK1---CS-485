using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseControl : MonoBehaviour {
	public GameObject playerpt2;
	float horizontalSpeed = 2.0f;
	float verticalSpeed = 2.0f;

	private Vector3 offset;

	//intialization for the camera
	void Start () {
		offset = transform.position - playerpt2.transform.position;
	}

	// Update is called once per frame
	void Update () 
	{
		 if (Input.GetAxis("Fire2") != 0) 
			{
			float h = horizontalSpeed * Input.GetAxis ("Mouse Y");
			float v = verticalSpeed * Input.GetAxis ("Mouse X");
			 	transform.Translate(v,h,0);
			}	
		
	}

	void LateUpdate () {
		transform.position = playerpt2.transform.position + offset;
	}
}
