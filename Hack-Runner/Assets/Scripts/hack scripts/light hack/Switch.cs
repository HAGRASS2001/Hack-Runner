using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject up;
    public GameObject on;
    public bool ison;
    public bool isup;
    // Start is called before the first frame update
    void Start()
    {
        up.SetActive(isup);
        on.SetActive(ison);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp() // mouse click but in boc colider
    {
        isup = !isup;
        ison = !ison;
        up.SetActive(isup);
        on.SetActive(ison);
        if (ison)
        {
            FindObjectOfType<wintext>().switchchange(1);
        }
        else {
            FindObjectOfType<wintext>().switchchange(-1);
        }
    }
}
