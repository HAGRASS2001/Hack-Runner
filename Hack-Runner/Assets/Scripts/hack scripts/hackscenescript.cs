using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hackscenescript : MonoBehaviour
{
    public KeyCode e;
    public KeyCode w;
    public bool triggerKey = false;
    public bool triggerCard = false;
    public bool triggerlight = false;
    public GameObject hackcheck;
    public GameObject cardhack;
    public GameObject lighthack;
    public Rigidbody2D player;
    public GameObject interaction;
    public bool interactionCheck;
    private bool guidance1Check = false;
    private bool guidance2Check = false;
    private bool guidance3Check = false;
    public bool scene2;
    public bool scene2LVL2;
    // Start is called before the first frame update
    void Start()
    {
        interactionCheck = false;
        player = FindObjectOfType<playercontroller>().gameObject.GetComponent<Rigidbody2D>();
        interaction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(w)) {
            if (scene2 == true)
            {
                Application.LoadLevel(5);
            }
            else if (scene2LVL2 == true)
            {
                Application.LoadLevel(7);
            }
        }
        if (Input.GetKey(e))
        {
            if (triggerKey == true)
            {
                interactionCheck = true;
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                FindObjectOfType<keyunlock>().x.SetActive(true);
                //FindObjectOfType<SwipeTask>().check.SetActive(true);
                hackcheck.SetActive(false);
                interaction.SetActive(false);
                FindObjectOfType<PlayerGuidance>().guidance1.SetActive(false);
                if (guidance1Check == true)
                {
                    FindObjectOfType<PlayerGuidance>().guidance1Part2.SetActive(true);
                }
            }
            if (triggerCard == true)
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                FindObjectOfType<SwipeTask>().check.SetActive(true);
                //FindObjectOfType<keyunlock>().x.SetActive(true);
                cardhack.SetActive(false);
                interaction.SetActive(false);
                FindObjectOfType<PlayerGuidance>().guidance2.SetActive(false);
                if (guidance2Check == true)
                {
                    FindObjectOfType<PlayerGuidance>().guidance2part2.SetActive(true);
                }
            }
            if (triggerlight == true)
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                FindObjectOfType<lighthackonandoff>().lighthack.SetActive(true);
                FindObjectOfType<PlayerGuidance>().guidance3.SetActive(false);
                lighthack.SetActive(false);
                interaction.SetActive(false);
                if(guidance3Check == true)
                {
                    FindObjectOfType<PlayerGuidance>().guidance3part2.SetActive(true);
                }
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "gotoscene2")
        {
            scene2 = true;
        }else if(other.tag == "gotoscene2LVL2")
        {
            scene2LVL2 = true;
        }
        if (other.tag == "hack")
        {
            triggerKey = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance1.SetActive(true);
            //GetComponent<playercontroller>().triggerhack = trigger;
            guidance1Check = true;
        }
        if (other.tag == "hack camera 2")
        {
            triggerKey = true;
            interaction.SetActive(true);
            //GetComponent<playercontroller>().triggerhack = trigger;

        }
        if (other.tag == "hack card")
        {
            triggerCard = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance2.SetActive(true);
            guidance2Check = true;
        }
        if (other.tag == "hack light")
        {
            triggerlight = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance3.SetActive(true);
            guidance3Check = true;
        }

       

        if (other.tag == "end") {
            triggerKey = false;
            triggerCard = false;
            interaction.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance1.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance2.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance3.SetActive(false);
            //GetComponent<playercontroller>().triggerhack = trigger;
        }
        else
        {
            FindObjectOfType<PlayerGuidance>().guidance2part2.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance3part2.SetActive(false);
        }
    }

    //IEnumerator Loadyourasynchack() {
    //    AsyncOperation synchack = SceneManager.LoadSceneAsync(3);

    //    while (!synchack.isDone) {
    //        yield return null;
    //    }
    //}

}
