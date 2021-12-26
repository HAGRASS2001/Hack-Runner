using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public float cameraspeed;
    public float minX, maxX;
    public float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<playercontroller>().transform; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (target != null) {
            Vector2 newcameraposition = Vector2.Lerp(transform.position, target.position, Time.deltaTime*cameraspeed);
            float Clampx = Mathf.Clamp(newcameraposition.x, minX, maxX);
            float Clampy = Mathf.Clamp(newcameraposition.y, minY, maxY);
            transform.position = new Vector3(Clampx, Clampy, -10f);
        }
    }
}
