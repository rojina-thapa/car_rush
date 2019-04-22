using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.Networking;

public class ScoreCoin : NetworkBehaviour {

	// Use this for initialization

	void OnTriggerEnter(Collider other)
	{
		//Debug.Log ("entered coin");
		if(other.GetComponent<CarController>())
		{
			other.GetComponent<CarController> ().score += 1;
			Destroy (this.gameObject);
		}
	}

}
