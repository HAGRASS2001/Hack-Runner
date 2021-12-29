using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerstats : MonoBehaviour {

	public int health = 3;
	public int lives = 2;

	private float flickertime = 0f;
	public float flickerduration = 0.1f;
	private SpriteRenderer spriterenderer;
	public bool isimmune = false;
	private float immunitytime = 0f;
	public float immunityduration = 1.5f;


	public GameObject healthicon1;
	public GameObject healthicon2;
	public GameObject healthicon3;

	public GameObject livesicon1;
	public GameObject livesicon2;
	// Use this for initialization
	void Start () {
		spriterenderer = this.gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isimmune == true)
		{
			SpriteFlicker();
			immunitytime = immunitytime + Time.deltaTime;
			if (immunitytime >= immunityduration)
			{
				this.isimmune = false;
				this.spriterenderer.enabled = true;
			}
		}

	}
	public void takedamage(int damage) {
		if (this.lives == 0 && this.health == 0)
		{
			Debug.Log("gameover");
			Destroy(this.gameObject);
		}
		if (this.isimmune == false) {
			this.health = this.health - damage;
			if (this.health == 2)
			{
				healthicon3.SetActive(false);
			}
			else if (health == 1)
			{
				healthicon2.SetActive(false);
			}
			else {
				healthicon1.SetActive(false);
			}
			if (this.health < 0) {
				this.health = 0;
			}
			if (this.lives > 0 && this.health == 0) {
				
				if (lives == 2) {
					healthicon3.SetActive(true);
					healthicon2.SetActive(true);
					healthicon1.SetActive(true);
					this.health = 3;
					livesicon1.SetActive(false);
					this.lives--;

				} else if (lives == 1) {
					livesicon2.SetActive(false);
					FindObjectOfType<lvlmanager>().RespawnPlayer();
					this.lives--;
					healthicon3.SetActive(true);
					healthicon2.SetActive(true);
					healthicon1.SetActive(true);
					livesicon1.SetActive(true);
					livesicon2.SetActive(true);
					this.health = 3;
					this.lives = 2;
				}
				
			}
		}
		playhitreaction();
	}
	void playhitreaction()
	{
		this.isimmune = true;
		this.immunitytime = 0f;
	}

	void SpriteFlicker()
	{
		if (this.flickertime < this.flickerduration)
		{
			this.flickertime = this.flickertime + Time.deltaTime;
		}
		else
		{
			spriterenderer.enabled = !(spriterenderer.enabled);
			this.flickertime = 0;
		}
	}

}
