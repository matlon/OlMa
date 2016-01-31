using UnityEngine;
using System.Collections;

public class PieceMovement : MonoBehaviour {

    public MovementSet ms;
    private Vector2[][] movementSet;

    // Use this for initialization
    void Start() {
        ms = GetComponent<MovementSet>();
        movementSet = ms.getMovementSet();
    }
	
	// Update is called once per frame
	void Update () {

    }

    public ArrayList GetValidMoves(Block[,] board, int cbx, int cbz)
    {
        ArrayList availableMoves = new ArrayList();
        foreach (Vector2[] vec in movementSet)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                if (isValidIndex(board, cbx + (int)vec[i].x, cbz + (int)vec[i].y) && board[cbx + (int)vec[i].x, cbz + (int)vec[i].y].CheckAvailable())
                {
                    availableMoves.Add(board[cbx + (int)vec[i].x, cbz + (int)vec[i].y]);
                }
                else
                {
                    break;
                }
            }
        }
        return availableMoves;
    }

    private bool isValidIndex(Block[,] board, int x, int z)
    {
        int maxX = board.GetUpperBound(0);
        int maxZ = board.GetUpperBound(1);
        return 0 <= x && 0 <= z && x <= maxX && z <= maxZ;
    }

    private Vector2 v (int x, int y)
    {
        return new Vector2(x, y);
    }

}
