﻿using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Lemming") {
			if(other.gameObject.GetComponent<LemmingController> ().countSaved)
				GameController.lemmingsSaved++;
			Destroy(other.gameObject);
		}
		else if(other.tag == "Bullet") {
			Destroy(other.gameObject);
		}
	}
}