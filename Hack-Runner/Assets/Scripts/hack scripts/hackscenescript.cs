using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hackscenescript : MonoBehaviour
{
    public KeyCode e;
    public bool triggerKey = false;
    public bool triggerCard = false;
    public GameObject hackcheck;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playercontroller>().gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(e))
        {
            if (triggerKey == true)
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                FindObjectOfType<keyunlock>().x.SetActive(true);
                //FindObjectOfType<SwipeTask>().check.SetActive(true);
                hackcheck.SetActive(false);
            }
            if(triggerCard == true)
            {
                player.constraints = RigidbodyConstraints2D.FreezeAll;
                //FindObjectOfType<keyunlock>().x.SetActive(true);
                FindObjectOfType<SwipeTask>().check.SetActive(true);
                hackcheck.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hack")
        {
            triggerKey = true;
            //GetComponent<playercontroller>().triggerhack = trigger;

        }
        if (other.tag == "hack camera 2")
        {
            triggerKey = true;
            //GetComponent<playercontroller>().triggerhack = trigger;

        }
        if (other.tag == "hack card 1")
        {
            triggerCard = true;
        }
        if (other.tag == "hack card 2")
        {
            triggerCard = true;
        }
        if (other.tag == "end") {
            triggerKey = false;
            triggerCard = false;
            //GetComponent<playercontroller>().triggerhack = trigger;
        }
    }

    //IEnumerator Loadyourasynchack() {
    //    AsyncOperation synchack = SceneManager.LoadSceneAsync(3);

    //    while (!synchack.isDone) {
    //        yield return null;
    //    }
    //}

}
