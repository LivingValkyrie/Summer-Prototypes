using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: SingletonMasterTester 
/// </summary>
public class SingletonMasterTester : MonoBehaviour {
	#region Fields

	#endregion

	void Start() {
		SingletonMaster.SingletonOneInstance.PrintOut();
		SingletonMaster.SingletonTwoInstance.PrintOut();
	}

	void Update() {}
}