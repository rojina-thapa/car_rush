using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

	[SyncVar]
	public string pname = "player";

	//[SyncVar]
	//public Color playerColor = Color.white;

	void OnGUI()
	{
		if (isLocalPlayer)
		{
			pname = GUI.TextField (new Rect (25, Screen.height - 40, 100, 30), pname);
			if (GUI.Button (new Rect (130, Screen.height - 40, 80, 30), "Change")) 
			{
				CmdChangeName (pname);
			}

			//string ip = MasterServer.ipAddress;
			//GUI.TextField (new Rect (25, Screen.height - 40, 100, 30), ip);
		}
			
	}

	[Command]
	public void CmdChangeName(string newName)
	{
		pname = newName;
	}

	void Start()
	{
		if (isLocalPlayer) {
			GetComponent<Camera> ().enabled = true;
			//SmoothCameraFollow.target = this.transform;

			//Renderer[] rends = (Renderer[])GetComponentInChildren<Renderer> ();
			//foreach (Renderer r in rends)
				//r.material.color = playerColor;
		}

		//this.transform.position = new Vector3 (Random.Range (-20, 20), 0, Random.Range (-20, 20));
	}
	
	// Update is called once per frame
	void Update () {

			this.GetComponentInChildren<TextMesh> ().text = pname;
		}
}
