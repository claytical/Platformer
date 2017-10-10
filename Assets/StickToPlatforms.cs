using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatforms : MonoBehaviour {


	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "Platform"){
			transform.parent = other.transform.parent;

		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Platform"){
			transform.parent = null;
		}
	} 

}
