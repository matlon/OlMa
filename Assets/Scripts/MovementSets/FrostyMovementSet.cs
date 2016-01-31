using UnityEngine;
using System.Collections;

public class FrostyMovementSet : MovementSet {
	public FrostyMovementSet()
	{
		movementSet = new Vector2[][] {
							new Vector2[] { v( 1, 1) },
							new Vector2[] { v( 2, 2) },
							new Vector2[] { v( 1,-1) },
							new Vector2[] { v( 2,-2) },
							new Vector2[] { v(-1,-1) },
							new Vector2[] { v(-2,-2) },
							new Vector2[] { v(-1, 1) },
							new Vector2[] { v(-2, 2) },
						};
	}
}
