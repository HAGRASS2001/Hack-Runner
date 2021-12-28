using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutScenes2  : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScene", 24);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Scene1LVL2");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
