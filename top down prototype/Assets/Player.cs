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

		Interact();
	}

	void Interact() {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.forward, out hit, rayLength)) {
				print(hit.transform.name);
			}
		}
	}

	void Move() {
		float hSpeed = Input.GetAxis("Horizontal");
		float vspeed = Input.GetAxis("Vertical");

		Vector3 velocity = new Vector3(hSpeed, 0, vspeed);

		transform.Translate(velocity * moveSpeed * Time.deltaTime);

		//todo fix this 
		//transform.rotation = Quaternion.LookRotation(velocity);
	}

	void OnDrawGizmos() {
		Gizmos.DrawRay(transform.position, transform.forward);
	}
}