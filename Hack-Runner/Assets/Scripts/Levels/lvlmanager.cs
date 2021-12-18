using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlmanager : MonoBehaviour {
	public GameObject checkpoint;
	// Use this for initialization
	void Start () {
		
	}

	public void RespawnPlayer() {
		FindObjectOfType<playercontroller>().transform.position = checkpoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
