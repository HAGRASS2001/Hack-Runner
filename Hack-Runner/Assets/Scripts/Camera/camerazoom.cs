using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{
    private Camera cam;
    public float zoomspeed;
    public KeyCode Zbutton;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(Zbutton))
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 4, Time.deltaTime * zoomspeed);
        }
        else {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 5, Time.deltaTime * zoomspeed);
        }
    }
}
