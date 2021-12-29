using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dron : MonoBehaviour
{
    // Start is called before the first frame update
    public float Horizontalspeed;
    public float Verticalspeed;
    public float amplitude;
    private Vector3 temp_position;
   

    // Start is called before the first frame update
    void Start()
    {
     
        temp_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        temp_position.x += Horizontalspeed;
        temp_position.y = Mathf.Sin(Time.realtimeSinceStartup * Verticalspeed) * amplitude;
        transform.position = temp_position;

    }
   
    }
