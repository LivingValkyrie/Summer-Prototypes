using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: Node 
/// </summary>
public class Node : MonoBehaviour {
	#region Fields

	public NodeType type;
	public bool isActive;

	public Material[] materials;

	#endregion

	void Start() {
		isActive = Random.Range(0, 3) == 0;

		if (isActive) {
			type = (NodeType) Random.Range(0, 3);
			GetComponent<Renderer>().material = materials[(int) type];
			print(type);
		} else {
			gameObject.SetActive(false);
		}
	}

	void Update() {}
}

public enum NodeType {
	Ore,
	Wood,
	Herb
}