using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGuidance : MonoBehaviour
{
    public GameObject guidance1;
    public GameObject guidance1Part2;
    public bool interactionCheck;
    public GameObject guidance2;
    public GameObject guidance2part2;
    public GameObject guidance3;
    public GameObject guidance3part2;
    public GameObject guidance3part3;
    public GameObject guidance4;
    public GameObject guidance4part2;
    public GameObject guidance5;
    public GameObject guidance5part2;
    public GameObject guidance5part3;
    public GameObject jordanguidance;
    // Start is called before the first frame update
    void Start()
    {
        guidance1.SetActive(false);
        guidance2.SetActive(false);
        guidance3.SetActive(false);
        guidance4.SetActive(false);
        guidance5.SetActive(false);
        guidance1Part2.SetActive(false);
        guidance2part2.SetActive(false);
        guidance3part2.SetActive(false);
        guidance3part3.SetActive(false);
        guidance4part2.SetActive(false);
        guidance5part2.SetActive(false);
        guidance5part3.SetActive(false);

    }
    public void ReturnInteraction()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
