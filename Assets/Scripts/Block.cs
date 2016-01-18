using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public bool isWalkable, isBlocked;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool CheckAvailable()
	{
		return (isWalkable && !isBlocked);
	}
}
