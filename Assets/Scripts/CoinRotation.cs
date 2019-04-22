using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {
	GameObject coin;
	// Use this for initialization
	void Start () {
		coin = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		Rotate ();
	}
	void Rotate(){
		//coin.GetComponent<Transform> ().Rotate(this.transform.position,1);
		coin.GetComponent<Transform> ().Rotate (0, 3, 0);
	}
}
