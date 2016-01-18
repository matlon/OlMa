using UnityEngine;
using System.Collections;

public class PieceSubclass : PieceBehaviour {

	// Use this for initialization
	void Start () {
		mr = GetComponent<MeshRenderer>();
		ph = GameObject.Find("TurnManager").GetComponent<PieceHandler>();
		selectColor = Color.blue;
	}

}
