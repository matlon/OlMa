using UnityEngine;
using System.Collections;

public class TextBehaviour : MonoBehaviour 
{
	private TextMesh tm;
	private Color startColor;

	void Start()
	{
		tm = this.GetComponent<TextMesh>();
		startColor = tm.color;
	}
	
	void OnMouseEnter()
	{
		print (startColor.ToString());
		tm.color = Color.red;
	}
	
	void OnMouseExit() 
	{
		print (startColor.ToString());
		tm.color = startColor;
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
