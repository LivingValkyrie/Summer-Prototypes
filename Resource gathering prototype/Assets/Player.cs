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
	public float rayLength = 5;

	#endregion

	void Update() {
		Move();

		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.forward, out hit, rayLength)) {
				print(hit.transform.name);
			}
		}
	}

	void Move() {
		float rotation = Input.GetAxis("Horizontal");
		float vspeed = Input.GetAxis("Vertical");

		Vector3 velocity = new Vector3(0, 0, vspeed);

		transform.Translate(velocity * moveSpeed * Time.deltaTime);
		transform.Rotate(0, rotation * rotSpeed, 0);
	}
}