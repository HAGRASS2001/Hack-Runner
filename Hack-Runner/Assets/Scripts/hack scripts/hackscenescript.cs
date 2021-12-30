using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hackscenescript : MonoBehaviour
{
    public KeyCode e;
    public KeyCode w;
    public bool triggerKey = false;
    public bool triggerKey2 = false;
    public bool triggerCard = false;
    public bool triggerlight = false;
    public bool triggerMap = false;
    public bool triggerofficemarca = false;
    public GameObject hackcheck;
    public GameObject cardhack;
    public GameObject lighthack;
    public GameObject maphack;
    public GameObject hackoffice;
    public Rigidbody2D player;
    public GameObject interaction;
    public GameObject SceneInteracftion;
    public bool interactionCheck;
    private bool guidance1Check = false;
    private bool guidance2Check = false;
    private bool guidance3Check = false;
    private bool guidance4Check = false;
    private bool guidance5Check = false;
    private bool scene2;
    private bool scene2LVL2;
    private bool gotolvl1scene3;
    private bool gotolvl2scene1;
    private bool gotolvl2scene2;
    private bool gotolvl3scene1;
    private bool gotolvl3scene2;
    private bool gotolvl4scene2;
    public Canvas dontdestroy;
    public GameObject dontdestroy2;
    public GameObject dontdestroy3;
    public GameObject dontdestroy4;
    public GameObject dontdestroyaudio;
    public GameObject audiolvl2;
    public GameObject audiolvl3;
    public GameObject audiolvl4;
    public GameObject Ending1;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playercontroller>().gameObject.GetComponent<Rigidbody2D>();
        interactionCheck = false;
        SceneInteracftion.SetActive(false);
        interaction.SetActive(false);
        Ending1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(w))
        {
            if (scene2 == true)
            {
                DontDestroyOnLoad(FindObjectOfType<playercontroller>().gameObject);
                SceneInteracftion.SetActive(false);
                DontDestroyOnLoad(dontdestroyaudio);
                DontDestroyOnLoad(dontdestroy);
                DontDestroyOnLoad(dontdestroy2);
                DontDestroyOnLoad(dontdestroy3);
                Application.LoadLevel(5);
            }
            if (gotolvl1scene3 == true)
            {
                DontDestroyOnLoad(FindObjectOfType<playercontroller>().gameObject);
                SceneInteracftion.SetActive(false);
                DontDestroyOnLoad(dontdestroyaudio);
                DontDestroyOnLoad(dontdestroy);
                DontDestroyOnLoad(dontdestroy2);
                DontDestroyOnLoad(dontdestroy3);
                Application.LoadLevel(8);
            }
            if (gotolvl2scene1 == true)
            {
                Destroy(FindObjectOfType<playercontroller>().gameObject);
                SceneInteracftion.SetActive(false);
                Destroy(dontdestroyaudio);
                SceneManager.LoadScene("CutScene 2");
            }
            if (gotolvl2scene2 == true)
            {
                DontDestroyOnLoad(FindObjectOfType<playercontroller>().gameObject);
                DontDestroyOnLoad(dontdestroy);
                DontDestroyOnLoad(dontdestroy2);
                DontDestroyOnLoad(dontdestroy3);
                DontDestroyOnLoad(dontdestroyaudio);
                SceneInteracftion.SetActive(false);
                SceneManager.LoadScene(7);
            }
            if (gotolvl3scene1 == true)
            {
                Destroy(FindObjectOfType<playercontroller>().gameObject);
                SceneInteracftion.SetActive(false);
                Destroy(FindObjectOfType<playercontroller>().gameObject.GetComponent<hackscenescript>().dontdestroy.gameObject);
                Destroy(dontdestroy2);
                Destroy(dontdestroy3);
                Destroy(dontdestroyaudio);
                SceneManager.LoadScene(11);
            }
            if (gotolvl3scene2 == true)
            {
                DontDestroyOnLoad(FindObjectOfType<playercontroller>().gameObject);
                DontDestroyOnLoad(dontdestroy);
                DontDestroyOnLoad(dontdestroy2);
                DontDestroyOnLoad(dontdestroy3);
                DontDestroyOnLoad(audiolvl3);
                SceneInteracftion.SetActive(false);
                SceneManager.LoadScene(14);
            }
            if (gotolvl4scene2 == true)
            {
                DontDestroyOnLoad(FindObjectOfType<playercontroller>().gameObject);
                DontDestroyOnLoad(dontdestroy);
                DontDestroyOnLoad(dontdestroy2);
                DontDestroyOnLoad(dontdestroy3);
                DontDestroyOnLoad(dontdestroy4);
                DontDestroyOnLoad(audiolvl4);
                SceneInteracftion.SetActive(false);
                SceneManager.LoadScene(17);
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
                SceneInteracftion.SetActive(false);
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
                if (guidance3Check == true)
                {
                    FindObjectOfType<PlayerGuidance>().guidance3part2.SetActive(true);
                }
            }
            if (triggerMap == true)
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                FindObjectOfType<finalhackonandoff>().display.SetActive(true);
                FindObjectOfType<finalhackonandoff>().keyboad.SetActive(true);
                FindObjectOfType<finalhackonandoff>().Terminal.SetActive(true);
                maphack.SetActive(false);
                FindObjectOfType<PlayerGuidance>().guidance4.SetActive(false);
                interaction.SetActive(false);
                if (guidance4Check == true)
                {
                    FindObjectOfType<PlayerGuidance>().guidance4part2.SetActive(true);
                }
            }
            if (triggerofficemarca == true)
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                FindObjectOfType<finalhackonandoff>().display.SetActive(true);
                FindObjectOfType<finalhackonandoff>().keyboad.SetActive(true);
                FindObjectOfType<finalhackonandoff>().Terminal.SetActive(true);
                hackoffice.SetActive(false);
                FindObjectOfType<PlayerGuidance>().guidance5.SetActive(false);
                interaction.SetActive(false);
                if(guidance5Check == true)
                {
                    FindObjectOfType<PlayerGuidance>().guidance5part2.SetActive(true);
                    FindObjectOfType<PlayerGuidance>().guidance5part3.SetActive(true);
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
        if (other.tag == "gotoscene2LVL2")
        {
            scene2LVL2 = true;
        }
        if (other.tag == "gotolvl1scene3")
        {
            gotolvl1scene3 = true;
            SceneInteracftion.SetActive(true);
        }
        if (other.tag == "gotolvl2scene1")
        {
            gotolvl2scene1 = true;
            SceneInteracftion.SetActive(true);
        }
        if (other.tag == "gotolvl2scene2")
        {
            gotolvl2scene2 = true;
            SceneInteracftion.SetActive(true);
        }
        if (other.tag == "gotolvl3scene1")
        {
            gotolvl3scene1 = true;
            SceneInteracftion.SetActive(true);
        }
        if (other.tag == "gotolvl3scene2")
        {
            gotolvl3scene2 = true;
            SceneInteracftion.SetActive(true);
        }
        if (other.tag == "gotolvl4scene2")
        {
            gotolvl4scene2 = true;
            SceneInteracftion.SetActive(true);
        }
        if (other.tag == "hack")
        {
            hackcheck = other.gameObject;
            triggerKey = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance1.SetActive(true);
            guidance1Check = true;
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
        if (other.tag == "hack map")
        {
            maphack = other.gameObject;
            triggerMap = true;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance4.SetActive(true);
            guidance4Check = true;
        }
        if (other.tag == "hackoffice")
        {
            hackoffice = other.gameObject;
            triggerofficemarca = true;
            gotolvl3scene2 = false;
            interaction.SetActive(true);
            FindObjectOfType<PlayerGuidance>().guidance5.SetActive(true);
            guidance5Check = true;
        }
        if (other.tag == "end") {
            triggerKey = false;
            triggerCard = false;
            triggerlight = false;
            triggerMap = false;
            triggerofficemarca = false;
            interaction.SetActive(false);
            SceneInteracftion.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance1.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance2.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance3.SetActive(false);
            FindObjectOfType<PlayerGuidance>().guidance2part2.SetActive(false);
        }
        if(other.tag == "AudioLVL2")
        {
            audiolvl2 = other.gameObject;
        }
        if(other.tag == "AudioLVL3")
        {
            audiolvl3 = other.gameObject;
        }
        if (other.tag == "AudioLVL4")
        {
            audiolvl4 = other.gameObject;
        }
        if(other.tag == "Ending")
        {
            Ending1.SetActive(true);
            player.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (other.tag == "FlashBack")
        {
            player.constraints = RigidbodyConstraints2D.FreezeAll;
            FindObjectOfType<FlashBack>().flashbackvid.SetActive(true);
            Invoke("TurnFlashBackOff", 5);
        }
    }
    public void TurnFlashBackOff()
    {
        FindObjectOfType<FlashBack>().flashbackvid.SetActive(false);
        player.constraints = RigidbodyConstraints2D.None;
        player.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    //IEnumerator Loadyourasynchack() {
    //    AsyncOperation synchack = SceneManager.LoadSceneAsync(3);

    //    while (!synchack.isDone) {
    //        yield return null;
    //    }
    //}

}
