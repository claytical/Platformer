using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour {
	public float diameter;
	private float x;
	private float y;
	private Vector3 origin;

	// Use this for initialization
	void Start () {
		origin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		x = origin.x + Mathf.Cos (Time.time * (diameter / 2));
		y = origin.y + Mathf.Sin (Time.time * (diameter / 2));
		transform.position = new Vector3 (x, y, origin.z);		
	}
}
