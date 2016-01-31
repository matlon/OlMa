using UnityEngine;
using System.Collections;

public class CameraDrag : MonoBehaviour {

    public float speed = 10;
    public float minMove = 0.05f;

    private Vector3 origin;
    private bool mouseDown, mouseMovement;
    private Vector3 pos;

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            origin = Input.mousePosition;
            mouseDown = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
            mouseMovement = false;
        }
        else if (!mouseMovement && mouseDown && Camera.main.ScreenToViewportPoint(Input.mousePosition - origin).magnitude > minMove)
        {
            pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            mouseMovement = true;
        }

        if (mouseMovement)
        {
            Vector3 oldPos = pos;
            pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //Vector3 move = new Vector3(pos.x * speed, 0, pos.y * speed);

            transform.Translate(speed * (oldPos - pos), Space.Self);
        }

	}
}
