using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        for (i = 1; i < SceneManager.sceneCount; i++)
        {
            StartCoroutine(Loadyourasynchack(i));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Loadyourasynchack(int i)
    {
        AsyncOperation synchack = SceneManager.LoadSceneAsync(i);

        while (synchack.isDone)
        {
            yield return null;
        }
    }
}
