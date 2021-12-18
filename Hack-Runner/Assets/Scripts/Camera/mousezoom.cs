using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousezoom : MonoBehaviour
{
    private Camera cam;
    public float targetzoom = 3;
    private float ScrollData;
    public float zoomspeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        targetzoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        ScrollData = Input.GetAxis("Mouse ScrollWheel");

        targetzoom = targetzoom - ScrollData;
        targetzoom = Mathf.Clamp(targetzoom, 3, 6);
    }
}
