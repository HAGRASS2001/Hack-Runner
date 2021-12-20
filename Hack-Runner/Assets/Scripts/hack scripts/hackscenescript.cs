using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hackscenescript : MonoBehaviour
{
    public KeyCode e;
    public bool trigger = false;
    public GameObject hackcheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(e))
        {
            if (trigger == true)
            {
                //x.SetActive(true);
                //hack.SetActive(false);
                //hack.SetActive(false);
                //Application.LoadLevel(3);
                //StartCoroutine(Loadyourasynchack());
                FindObjectOfType<keyunlock>().x.SetActive(true);
                //FindObjectOfType<SwipeTask>().check.SetActive(true);
                hackcheck.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "hack")
        {
            trigger = true;
            //GetComponent<playercontroller>().triggerhack = trigger;

        }
        if (other.tag == "end") {
            trigger = false;
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
