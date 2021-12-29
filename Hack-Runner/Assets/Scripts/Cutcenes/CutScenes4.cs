using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutScenes4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNewScene", 22);
    }
    public void LoadNewScene()
    {
        SceneManager.LoadScene(16);
    }
}
