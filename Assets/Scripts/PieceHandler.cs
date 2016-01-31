using UnityEngine;
using System.Collections;

public class PieceHandler : MonoBehaviour {

	private bool hasSelectedPiece;
	private PieceBehaviour currentMarkedPiece;
	private Block[,] board;
	private int[,] matrixTemplate;
	private ArrayList availableMoves;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetSelectedPiece(PieceBehaviour p)
	{
		if (currentMarkedPiece != null) currentMarkedPiece.Deselect();
		currentMarkedPiece = p;
		currentMarkedPiece.Select();
		hasSelectedPiece = true;

		CheckAvailableMoves();

	}

	public void ClearSelectedPiece()
	{
		currentMarkedPiece.Deselect();
		hasSelectedPiece = false;
	}

	public bool GetHasSelectedPiece()
	{
		return hasSelectedPiece;
	}

	public PieceBehaviour GetSelectedPiece()
	{
		return currentMarkedPiece;
	}

	public void MoveSelectedPiece(int x, int y, int z)
	{
		currentMarkedPiece.transform.position = new Vector3(x, y, z);
		board[currentMarkedPiece.GetMatrixPositionX(), currentMarkedPiece.GetMatrixPositionZ()].isBlocked = false;
		currentMarkedPiece.SetMatrixPosition(x, z);
		ClearSelectedPiece();
	}

	public void CheckAvailableMoves()
	{
		int cbx = currentMarkedPiece.GetMatrixPositionX();
		int cbz = currentMarkedPiece.GetMatrixPositionZ();

		currentMarkedPiece.GetComponent<PieceMovement>();

		availableMoves = currentMarkedPiece.GetComponent<PieceMovement>().GetValidMoves(board, cbx, cbz);
	}

	private bool isValidIndex(int x, int z)
	{
		int maxX = board.GetUpperBound(0);
		int maxZ = board.GetUpperBound(1);
		return 0 <= x && 0 <= z && x <= maxX && z <= maxZ;
	}

	public ArrayList GetAvailableMoves()
	{
		return availableMoves;
	}

	public void SaveBoard(Block[,] b, int[,] mt)
	{
		board = b;
		matrixTemplate = mt;
	}
}
