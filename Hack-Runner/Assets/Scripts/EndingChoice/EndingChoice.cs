using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingChoice : MonoBehaviour
{
    public GameObject LastMusic;
    // Start is called before the first frame update
    void Start()
    {
        LastMusic = FindObjectOfType<hackscenescript>().audiolvl4;
    }
    public void PlayEnding1()
    {
        Destroy(LastMusic);
        SceneManager.LoadScene(16);
    }
    public void PlayEnding2()
    {
        Destroy(LastMusic);
        SceneManager.LoadScene(17);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
