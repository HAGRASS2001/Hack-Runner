using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBack : MonoBehaviour
{
    public GameObject flashbackvid;
    // Start is called before the first frame update
    void Start()
    {
        flashbackvid.SetActive(false); 
    }
}
