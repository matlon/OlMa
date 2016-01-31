using UnityEngine;
using System.Collections;

public class MovementSet : MonoBehaviour {
    protected Vector2[][] movementSet;
    
    public MovementSet()
    {
        movementSet = new Vector2[][] {
            new Vector2[] {}
        };
    }

    protected static Vector2 v(int x, int y)
    {
        return new Vector2(x, y);
    }

    public Vector2[][] getMovementSet()
    {
        return movementSet;
    }
}
