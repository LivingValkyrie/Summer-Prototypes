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

	public Material[] materials;

	#endregion

	void Start() {
		type = (NodeType) Random.Range(0, 3);
		GetComponent<Renderer>().material = materials[(int) type];
		print(type);
	}

	void Update() {}
}

public enum NodeType {
	Ore,
	Wood,
	Herb
}