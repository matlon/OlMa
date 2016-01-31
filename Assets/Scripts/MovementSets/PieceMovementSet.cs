using UnityEngine;
using System.Collections;

public class PieceMovementSet : MovementSet {
    public PieceMovementSet()
    {
        movementSet = new Vector2[][] {
                            new Vector2[] { v( 1, 1) },
                            new Vector2[] { v( 1, 0) },
                            new Vector2[] { v( 1,-1) },
                            new Vector2[] { v( 0,-1) },
                            new Vector2[] { v(-1,-1) },
                            new Vector2[] { v(-1, 0) },
                            new Vector2[] { v(-1, 1) },
                            new Vector2[] { v( 0, 1) },
                        };
    }
}
