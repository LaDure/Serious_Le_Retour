using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBehaviour : MonoBehaviour {

    public float rotateSpeed = 5.0f;
    public float translateSpeed = 0.5f;

    private float eulerY;
    private float maxEulerY = 90.0f;

    // Use this for initialization
    void Start ()
    {
        this.eulerY = this.transform.eulerAngles.y;
    }

    private void OnMouseDrag()
    {
        if(!UIManager.Instance.InUi)
            this.Translate();
    }

    public void Translate()
    {
        this.transform.Translate(new Vector3(-Input.GetAxis("Mouse X") * translateSpeed, 0.0f,
            -Input.GetAxis("Mouse Y") * translateSpeed));
    }

    public void Rotate()
    {
        this.transform.Rotate(new Vector3(0.0f, -Input.GetAxis("Mouse X") * rotateSpeed, 0.0f));

        if (this.transform.eulerAngles.y > this.eulerY + this.maxEulerY)
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x,
                this.eulerY + this.maxEulerY, 0.0f);
        }
        else if (this.transform.eulerAngles.y < this.eulerY - this.maxEulerY)
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x,
                this.eulerY - this.maxEulerY, 0.0f);
        }
    }
}
