using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float zoomSpeed = 5.0f;

    public RoomBehaviour target;

    public Transform CameraTarget;


    private void Awake()
    {
        this.target.transform.position = Camera.main.ScreenToWorldPoint(
                new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 10.0f));     
    }

    private void Update()
    {
        //this.UpdateInput();
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

    private IEnumerator Pause()
    {
        yield return new WaitForSeconds(5);
    }

    private IEnumerator SlideTo(Vector3 destination)
    {
        yield return new WaitForSeconds(2.5f);

        while ((destination - Camera.main.transform.position).sqrMagnitude > 0.0625f)
        {
            Camera.main.transform.position = Vector3.Lerp(
                 Camera.main.transform.position, destination, 2.0f * Time.deltaTime);

            Camera.main.transform.LookAt(target.transform);
            
            yield return null;
        }

        //Camera.main.transform.position = destination;
    }

    public void Init()
    {
        StartCoroutine(SlideTo(CameraTarget.position));
    }
}
