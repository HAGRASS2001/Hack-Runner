using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wintext : MonoBehaviour
{
    public int switchcount;
    public GameObject WinText;

    private int oncount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchchange(int points) {
        oncount += points;
        if (oncount ==  switchcount) {
            //WinText.SetActive(true);
            FindObjectOfType<lighthackonandoff>().lighthack.SetActive(false);
            FindObjectOfType<hackscenescript>().player.constraints = RigidbodyConstraints2D.FreezeRotation;

        }
    }
}
