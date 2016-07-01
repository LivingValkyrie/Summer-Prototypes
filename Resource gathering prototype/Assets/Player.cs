using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: Player 
/// </summary>
public class Player : MonoBehaviour {

	#region Fields

	public float moveSpeed = 10;
	public float rotSpeed = 5;

	#endregion
	
	void Start () {
	
	}
	
	void Update () {

		float rotation = Input.GetAxis("Horizontal");
		float vspeed = Input.GetAxis("Vertical");

		Vector3 velocity = new Vector3(0, 0, vspeed); 

		transform.Translate( velocity * moveSpeed * Time.deltaTime);
		transform.Rotate(0, rotation * rotSpeed, 0);

	}
}
