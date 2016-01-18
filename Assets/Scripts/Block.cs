using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public bool isWalkable, isBlocked;
    public bool hasMouseOver;
    public GameObject marker;

	// Use this for initialization
	void Start () {
        marker = GameObject.Find("Selection Marker");
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseEnter ()
    {
        marker.transform.position = new Vector3(transform.position.x, marker.transform.position.y, transform.position.z);
    }

	public bool CheckAvailable()
	{
		return (isWalkable && !isBlocked);
	}
}
