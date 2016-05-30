using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: SingletonOne 
/// </summary>
public class SingletonOne : MonoBehaviour {
	#region Fields

	public static SingletonOne instance;
	bool hasPrinted = false;

	#endregion

	void Start() {
		instance = this;
	}

	void Update() {
		if (!instance.hasPrinted) {
			print("update call");
			hasPrinted = true;
		}
	}

	public void PrintOut() {
		print(instance.name + " has been created");
	}
}