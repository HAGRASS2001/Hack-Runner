using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hackscenescript : MonoBehaviour
{
    public bool trigger = false;
    public GameObject hackcheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hack")
        {
            trigger = true;
            GetComponent<playercontroller>().triggerhack = trigger;
        }
        if (other.tag == "end") {
            trigger = false;
            GetComponent<playercontroller>().triggerhack = trigger;
        }
    }

}
