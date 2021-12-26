using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class GameGuidance : MonoBehaviour
{
    public GameObject gameGuidance1;
    public GameObject gameGuidance2;
    public GameObject gameGuidance3;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playercontroller>().gameObject.GetComponent<Rigidbody2D>();
        gameGuidance1.SetActive(false);
        gameGuidance1.SetActive(false);
        gameGuidance3.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GameGuidance1");
        {
            player.constraints = RigidbodyConstraints2D.FreezeAll;
            gameGuidance1.SetActive(true);
            Invoke("SecondGuidance", 8f);
        }
    }
    public void SecondGuidance()
    {
        gameGuidance1.SetActive(false);
        gameGuidance2.SetActive(true);
        Invoke("ThirdGuidance", 8f);
    }
    public void ThirdGuidance()
    {
        gameGuidance2.SetActive(false);
        gameGuidance3.SetActive(true);
        Invoke("FourthStep", 8f);
    }
    public void FourthStep()
    {
        gameGuidance3.SetActive(false);
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
