using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float zoomSpeed = 5.0f;

    public RoomBehaviour target;

    private void Awake()
    {
        this.target.transform.position = Camera.main.ScreenToWorldPoint(
                new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 10.0f));
    }
    private void Update()
    {
        this.UpdateInput();
    }

    private void UpdateInput()
    {
        if (Input.GetMouseButton(1))
        {
            target.Rotate();
        }

       /* if(Input.GetMouseButton(0))
        {
            target.Translate();
        }*/

        this.Zoom();
    }

    private void Zoom()
    {
        this.transform.Translate(0, 0, Input.GetAxis("Mouse ScrollWheel") * this.zoomSpeed, Space.Self);
    }
}
