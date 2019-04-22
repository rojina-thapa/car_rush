using System.Collections;
using UnityEngine;
using DatabaseControl;

public class UserAccountManager : MonoBehaviour {

	public static UserAccountManager instance;

	void Awake()
	{
		if (instance != null) 
		{
			Destroy (gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad (this);
	}

	public static string PlayerUsername { get; protected set; }
	public static string PlayerPassword { get; protected set; }
}
