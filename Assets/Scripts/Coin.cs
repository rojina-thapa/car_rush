using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;



public class Coin : NetworkBehaviour {

	//[SyncVar]
	//public int totalCoin = 0; 

	public int coinValue;
	public Text scoreText;

	//int cmdtotalCoin();


	//private GameObject coinManager;
	// Use this for initialization


	void Start () {

		coinValue = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (isLocalPlayer) {
			//coinManager = GameObject.FindGameObjectWithTag ("CoinManger");
		

		scoreText.text = "Score: " + coinValue.ToString ();
		}


	}

	void OnTriggerEnter(Collider other) //trigger event. player will cause a trigger even if it collides withthe other gameobject
	{
		//if (isLocalPlayer) {
			if (other.tag == "Coin") {

				coinValue = coinValue + 15;
				Destroy (other.gameObject); //destroys the gameObject colliding not the player
				//coinManager.GetComponent<CoinManager> ().UpdateCoin ();
				//cmdtotalCoin();
			}
		//}
	}

	//[Command]
	//public void cmdtotalCoin()
	//{
		//totalCoin += 5;
	//}

}
