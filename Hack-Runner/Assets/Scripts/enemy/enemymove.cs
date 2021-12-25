using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<walkerenemy>().enemy.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
