using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: Room 
/// </summary>
public class Room : MonoBehaviour {

	#region Fields

	public Vector3 localCamPos = new Vector3(0, 8.85f, -2.04f);
	Vector3 camPos;
	#endregion

	void Awake() {
		camPos = transform.TransformPoint(localCamPos);
	}

	public void MoveCamera(Transform cameraToMove) {
		cameraToMove.position = camPos;
	}

}
