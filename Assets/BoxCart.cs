using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCart : MonoBehaviour {
	public Camera camera;
	private bool driving;
	private Camera previousCamera;
	private GameObject FPSController;
	// Use this for initialization
	void Start () {
		driving = false;
		previousCamera = Camera.main;

	}

	
	// Update is called once per frame
	void Update () {
		if (driving) {
			Drive ();
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			if (driving) {
				StopDriving ();
			} 
		}
	}

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Player") {
			FPSController = other.gameObject;
			FPSController.transform.parent = gameObject.transform;
			camera.gameObject.SetActive (true);
			previousCamera.enabled = false;
			camera.enabled = true;
			driving = true;
		}

	}
		
	void StopDriving() {
		GetComponent<Rigidbody> ().velocity = Vector3.zero;
		previousCamera.enabled = true;
		camera.gameObject.SetActive (false);
		driving = false;
		FPSController.transform.parent = null;
		FPSController.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 2.4f);
	}



	void Drive() {
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody> ().velocity += Vector3.forward;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody> ().velocity += Vector3.back;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody> ().velocity += Vector3.left;
			transform.Rotate (0, -.5f, 0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody> ().velocity += Vector3.right;
			transform.Rotate (0, .5f, 0);

		}

	}
}
