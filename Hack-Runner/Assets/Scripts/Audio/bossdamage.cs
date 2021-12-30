using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossdamage : MonoBehaviour
{
    public AudioSource efxsource;
    public AudioSource musicsource;
    public static bossdamage instance = null;
    public float lowpitchrange = .95f;
    public float highpitchrange = 1.05f;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void playersingle(AudioClip clip)
    {
        efxsource.clip = clip;
        efxsource.Play();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

