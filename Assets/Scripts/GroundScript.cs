using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {

	public PieceHandler ph;
	private Block block;

	// Use this for initialization
	void Start () {
		ph = GameObject.Find("GlobalManager").GetComponent<PieceHandler>();
		block = gameObject.GetComponent<Block>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if (ph.GetHasSelectedPiece() && ph.GetAvailableMoves().Contains(block))
		{
			Vector3 pos = this.transform.position + Vector3.up;
			ph.MoveSelectedPiece((int) pos.x, (int) pos.y, (int) pos.z);
			gameObject.GetComponent<Block>().isBlocked = true;
		}
	}
}
