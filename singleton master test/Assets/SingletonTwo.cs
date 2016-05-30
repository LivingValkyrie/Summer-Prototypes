using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: SingletonTwo 
/// </summary>
public class SingletonTwo : MonoBehaviour {
	#region Fields

	public static SingletonTwo instance;
	bool hasPrinted = false;

	#endregion

	void Awake() {
		if (instance == null) {
			instance = this;
		} else {
			print( "destroying gameobject for two" );
			if ( instance != this ) {
				Destroy( gameObject );
			}
		}
	}

	void Update() {
		if (!instance.hasPrinted) {
			print("update call");
			hasPrinted = true;
		}
	}

	public void PrintOut() {
		print(instance.name + " printout has been called" );
	}
}