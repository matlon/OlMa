using UnityEngine;
using System.Collections;

public class PieceBehaviour : MonoBehaviour {
	
	public bool isSelected;
	protected PieceHandler ph;
	protected MeshRenderer mr;

	public Vector2 matrixPosition;
	public Color selectColor = Color.red;
	public int type = 0;

	// Use this for initialization
	void Start () {
		mr = GetComponent<MeshRenderer>();
		ph = GameObject.Find("GlobalManager").GetComponent<PieceHandler>();
		matrixPosition = new Vector2(1,1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () 
	{
		if (!isSelected) 	// Select this Piece
		{
			ph.SetSelectedPiece(this);
		} 
		else 				// Deselect this Piece 
		{
			ph.ClearSelectedPiece();
		}
	}

	public void Select()
	{
		mr.material.color = selectColor;
		isSelected = true;
	}

	public void Deselect()
	{
		mr.material.color = Color.white;
		isSelected = false;
	}

	public void SetMatrixPosition(int x, int z)
	{
		matrixPosition = new Vector2(x, z);
	}
	
	public int GetMatrixPositionX()
	{
		return (int )matrixPosition.x;
	}
	
	public int GetMatrixPositionZ()
	{
		return (int )matrixPosition.y;
	}

	public int GetType()
	{
		return type;
	}
}
