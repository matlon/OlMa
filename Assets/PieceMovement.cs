using UnityEngine;
using System.Collections;

public class PieceMovement : MonoBehaviour {

    Vector2[,] movementSet;

	// Use this for initialization
	void Start () {
        Vector2[,] m =  {
                            { v(1, 2) },
                            { v(-1, 2) },
                            { v(1, -2) },
                            { v(-1, -2) },
                            { v(2, 1) },
                            { v(-2, 1) },
                            { v(2, -1) },
                            { v(-2, -1) }
                        };
        movementSet = m;
    }
	
	// Update is called once per frame
	void Update () {

    }
    
    private Vector2 v (int x, int y)
    {
        return new Vector2(x, y);
    }

}
