using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsitacle : MonoBehaviour
{
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject o5;
    public GameObject o6;
    public bool ob1;
    public bool ob2;
    public bool ob3;
    public bool ob4;
    public bool ob5;
    public bool ob6;
    // Start is called before the first frame update
    void Start()
    {
        o1.SetActive(true);
        o2.SetActive(true);
        o3.SetActive(true);
        o4.SetActive(true);
        o5.SetActive(true);
        o6.SetActive(true);
        ob1 = false;
        ob2 = false;
        ob3 = false;
        ob4 = false;
        ob5 = false;
        ob6 = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag== "Player"&&ob1==false)
        {
            o1.SetActive(false);
            o2.SetActive(true);
            o3.SetActive(true);
            ob1 = true;
        }
         if (other.tag == "Player"&&ob2==false) {

            o1.SetActive(false);
            o2.SetActive(false);
            o3.SetActive(true);
            ob2 = true;
        }
         if (other.tag == "Player" && ob3 == false)
        {
            o1.SetActive(false);
            o2.SetActive(false);
            o3.SetActive(false);
            ob3 = true;
        }
         if (other.tag == "Player" && ob4 == false)
        {
            o1.SetActive(false);
            o2.SetActive(false);
            o3.SetActive(false);
            o4.SetActive(false);
            ob4 = true;
        }
         if (other.tag == "Player" && ob5 == false)
        {
            o1.SetActive(false);
            o2.SetActive(false);
            o3.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            ob5 = true;
        }
         if (other.tag == "Player" && ob6 == false)
        {
            o1.SetActive(false);
            o2.SetActive(false);
            o3.SetActive(false);
            o4.SetActive(false);
            o5.SetActive(false);
            o6.SetActive(false);
            ob6 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
