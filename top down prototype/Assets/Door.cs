using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: Door 
/// </summary>
public class Door : MonoBehaviour {

	#region Fields

	public Room nextRoom;
	public Door matchingDoor;

	public Vector3 spawnPos = Vector3.zero;
	#endregion

	void Start() {
		spawnPos = transform.TransformPoint( spawnPos );
	}

	public void OnTriggerEnter( Collider other ) {
		print( "Trigger" );
		if ( other.tag == "Player" ) {
			Time.timeScale = 0;
			nextRoom.MoveCamera( Camera.main.transform );//todo update to a transistion and not a teleport
			other.transform.position = matchingDoor.spawnPos;
			Time.timeScale = 1;
		}
	}

	public void OnTriggerExit( Collider other ) {

	}
}
