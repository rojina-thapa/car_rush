using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishing : MonoBehaviour{ 	// Use this for initializations
	
	// Update is called once per frameate () {


	void OnTriggerEnter(Collider other) //trigger event. player will cause a trigger even if it collides withthe other gameobject
	{
		Debug.Log (other.tag);
		//if (isLocalPlayer) {
		if (other.tag == "Finish") {
			Debug.Log ("ss");
			//Destroy (other.gameObject);
			SceneManager.LoadScene ("GameOver");
			//Destroy (other.gameObject); //destroys the gameObject colliding not the player

		}
		//}
	}

}