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
    public GameObject SceneInteracftion;
    public bool interactionCheck;
    private bool guidance1Check = false;
    private bool guidance2Check = false;
    private bool guidance3Check = false;
    private bool scene2;
    private bool scene2LVL2;
    private bool gotolvl1scene3;
    public Canvas dontdestroy;
    // Start is called before the first frame update
    void Start()
    {
        interactionCheck = false;
        SceneInteracftion.SetActive(false);
        player = FindObjectOfType<playercontroller>().gameObject.GetComponent<Rigidbody2D>();
        interaction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(w)) {
            if (scene2 == true)
            {
                DontDestroyOnLoad(FindObjectOfType<playercontroller>().gameObject);
                DontDestroyOnLoad(dontdestroy);
                Application.LoadLevel(5);
            }
            if (scene2LVL2 == true)
            {
                Application.LoadLevel(7);
            }
            if (gotolvl1scene3 == true)
            {
                DontDestroyOnLoad(FindObjectOfType<playercontroller>().gameObject);
                DontDestroyOnLoad(dontdestroy);
                Application.LoadLevel(8);
            }
        }
        if (Input.GetKey(e))
        {
            if (triggerKey == true)
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                FindObjectOfType<keyunlock>().x.SetActive(true);
                hackcheck.SetActive(false);
                //FindObjectOfType<SwipeTask>().check.SetActive(true);
                interactionCheck = true;
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
                lighthack.SetActive(false);
                FindObjectOfType<PlayerGuidance>().guidance3.SetActive(false);
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
            SceneInteracftion.SetActive(true);
            scene2 = true;
        }
        if(other.tag == "gotoscene2LVL2")
        {
            scene2LVL2 = true;
        }
        if (other.tag == "gotolvl1scene3")
        {
            gotolvl1scene3 = true;
        }
        if (other.tag == "hack")
        {
            hackcheck = other.gameObject;
            triggerKey = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance1.SetActive(true);;
            guidance1Check = true;
        }
        if (other.tag == "hack camera 2")
        {
            triggerKey = true;
            interaction.SetActive(true);

        }
        if (other.tag == "hack card")
        {
            cardhack = other.gameObject;
            triggerCard = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance2.SetActive(true);
            guidance2Check = true;
        }
        if (other.tag == "hack light")
        {
            lighthack = other.gameObject;
            triggerlight = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance3.SetActive(true);
            guidance3Check = true;
        }

       

        if (other.tag == "end") {
            triggerKey = false;
            triggerCard = false;
            triggerlight = false;
            interaction.SetActive(false);
            SceneInteracftion.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance1.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance2.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance3.SetActive(false);
        }
    }

    //IEnumerator Loadyourasynchack() {
    //    AsyncOperation synchack = SceneManager.LoadSceneAsync(3);

    //    while (!synchack.isDone) {
    //        yield return null;
    //    }
    //}

}
