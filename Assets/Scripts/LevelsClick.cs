using UnityEngine;
using System.Collections;

public class LevelsClick : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnMouseUp()
	{
		// Temporary load the preset map
		Application.LoadLevel (1);
	} 
}
