using UnityEngine;
using System.Collections;

public class PieceMovement : MonoBehaviour {

    Vector2[][] movementSet;

    // Use this for initialization
    void Start() {
        Vector2[][] m = new Vector2[][] {
                            new Vector2[] { v( 1, 1), v( 2, 2) },
                            new Vector2[] { v(-1, 2) },
                            new Vector2[] { v( 1,-2) },
                            new Vector2[] { v(-1,-2) },
                            new Vector2[] { v( 2, 1) },
                            new Vector2[] { v(-2, 1) },
                            new Vector2[] { v( 2,-1) },
                            new Vector2[] { v(-2,-1) }
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
