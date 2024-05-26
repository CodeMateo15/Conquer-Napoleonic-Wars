using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float panSpeed = 10f;
    public Vector2 panLimit;

    public float zoomSize = 25;

    private bool drag = false;
    private Vector3 ResetCamera;
    private Vector3 Origin;
    private Vector3 Difference;

    public bool slider;

    private void Start()
    {
        ResetCamera = Camera.main.transform.position;
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (slider == false)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                if (zoomSize < 30)
                {
                    zoomSize += 1;
                }
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                if (zoomSize > 10)
                {
                    zoomSize -= 1;
                }
            }
        }

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, -panLimit.y, panLimit.y);
        //border blocking code

        transform.position = pos;

        GetComponent<Camera>().orthographicSize = zoomSize;
    }

    private void LateUpdate()
    {
        if (slider == false)
        {
            if (Input.GetMouseButton(0))
            {
                Difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
                if (drag == false)
                {
                    drag = true;
                    Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }
            }
            else
            {
                drag = false;
            }
            if (drag)
            {
                Camera.main.transform.position = Origin - Difference;
            }

            if (Input.GetMouseButton(1))
            {
                Camera.main.transform.position = ResetCamera;
            }
        }
    }
}