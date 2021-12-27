using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutScenes1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScene1LVL1", 74);
    }
    public void LoadScene1LVL1()
    {
        SceneManager.LoadScene("scene1(intro)");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
