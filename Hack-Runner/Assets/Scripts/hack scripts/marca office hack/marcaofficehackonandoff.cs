using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marcaofficehackonandoff : MonoBehaviour
{
    public GameObject display;
    public GameObject keyboad;
    public GameObject Terminal;
    // Start is called before the first frame update
    void Start()
    {
        display.SetActive(false);
        keyboad.SetActive(false);
        Terminal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
