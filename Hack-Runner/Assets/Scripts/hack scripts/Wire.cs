using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPoint;
    Vector3 startPosition;
    public GameObject lighOn;
    public SpriteRenderer wireEnd;
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = transform.position;
    }
    private void OnMouseDrag() { 
   // mouse position to world point
    Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    newPosition.z = 0;

        Updatewire(newPosition);


        //check for nearby connection points

       Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, .2f);
        foreach (Collider2D collider in colliders)
        {
            //make sure not my own collider
            if (collider.gameObject != gameObject)
            {
                //update wire to the connection point position
                Updatewire(collider.transform.position);

                //check if the wires are same color
                //if (transform.parent.name.Equals(collider.transform.parent.name))
                //{
                //    //finish step
                //    collider.GetComponent<Wire>()?.Done();
                //    Done();
                //}

                return;
            }
        }
    }

    void Done()
    {
        // turn on light
        lighOn.SetActive(true);
        // destory the script
        Destroy(this);
    }

    void Updatewire(Vector3 newPosition) {
        // update position
        transform.position = newPosition;   
        // update direction
        Vector3 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;
          // update scale
   float dist = Vector2.Distance(new Vector3(startPoint.x-1, startPoint.y, startPoint.z), newPosition);
        wireEnd.size = new Vector2(dist, wireEnd.size.y);
    }
    // Update is called once per frame

    void Update()
    {

     }
}
