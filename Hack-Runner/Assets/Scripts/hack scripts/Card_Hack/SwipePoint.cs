using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwipePoint : MonoBehaviour
{
    // Start is called before the first frame update

private SwipeTask _swipeTask;
    
private void Awake()
    {
        _swipeTask = GetComponentInParent<SwipeTask>();
    }
private void OnTriggerEnter2D(Collider2D other)
        {
            _swipeTask.SwipePointTrigger(this);

        }

          void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
