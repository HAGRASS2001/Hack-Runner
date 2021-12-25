using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public Rigidbody2D enemy;
    public Rigidbody2D enemy2;
    public Rigidbody2D enemy3;
    // Start is called before the first frame update
    void Start()
    {
        enemy.constraints = RigidbodyConstraints2D.FreezeAll;
        enemy2.constraints = RigidbodyConstraints2D.FreezeAll;
        enemy3.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            enemy.constraints = RigidbodyConstraints2D.FreezeRotation;
            enemy2.constraints = RigidbodyConstraints2D.FreezeRotation;
            enemy3.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
