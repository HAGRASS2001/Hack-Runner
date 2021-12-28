using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutScenes3  : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScene", 33);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(12);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
