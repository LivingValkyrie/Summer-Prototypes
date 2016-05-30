using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: SingletonMaster 
/// </summary>
public static class SingletonMaster {
	#region Fields

	public static SingletonOne SingletonOneInstance {
		get {
			if (SingletonOne.instance) {
				return SingletonOne.instance;
			} else {
				GameObject temp = new GameObject("SingletonOne Instance");
				SingletonOne.instance = temp.AddComponent<SingletonOne>();
				return SingletonOne.instance;
			}
		}
	}

	public static SingletonTwo SingletonTwoInstance {
		get {
			if (SingletonTwo.instance) {
				return SingletonTwo.instance;
			} else {
				GameObject temp = new GameObject("SingletonTwo Instance");
				SingletonTwo.instance = temp.AddComponent<SingletonTwo>();
				return SingletonTwo.instance;
			}
		}
	}

	#endregion
}