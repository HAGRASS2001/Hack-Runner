using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlmanager : MonoBehaviour {
	public GameObject checkpoint;
	public AudioClip death;
	// Use this for initialization
	void Start () {
		
	}

	public void RespawnPlayer() {
		AudioController.instance.playersingle(death);
		FindObjectOfType<playercontroller>().transform.position = checkpoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
