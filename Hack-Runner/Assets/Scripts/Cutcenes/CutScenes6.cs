using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutScenes6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<hackscenescript>().Ending1.SetActive(false);
        Invoke("LoadNewScene", 80);
    }
    public void LoadNewScene()
    {
        SceneManager.LoadScene(2);
    }
}
