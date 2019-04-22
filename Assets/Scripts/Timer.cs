using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private string levelToLoad;
	public float timeleft= 180f;
	private Text timerSeconds;
	//private float startTime;


	// Use this for initialization
	void Start () {
		//timeRemaining == Time.time;

		timerSeconds = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		//timeRemaining -= Time.deltaTime;

		timeleft -= Time.deltaTime;
		timerSeconds.text = timeleft.ToString ("f0");
		if (timeleft <= 0) {
			//Application.LoadLevel (levelToLoad);
			SceneManager.LoadScene ("Login");
		}
		
	}
	//void OnGUI(){
		//if (timeRemaining > 0) {
			//GUI.Label (new Rect (100, 100, 200, 100), "Time Remaining:" + timeRemaining);
		//	GUI.Label (new Rect(100, 100, 200, 100) , "Time Remaining:" + timeRemaining);
		//} else {
		//	GUI.Label (new Rect (100, 100, 200, 100), "TIME UP");
		//}
	//}
}
