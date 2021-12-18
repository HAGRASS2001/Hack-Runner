using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerstats : MonoBehaviour {

	public int health = 3;
	public int lives = 2;

	private float flickertime = 0f;
	public float flickerduration = 0.1f;

	private SpriteRenderer spriteRenderer;

	public bool isimmune = false;
	private float immunitytime = 0F;
	public float immuntyduration = 1.5f;

	public Image healthicon1;
	public Image healthicon2;
	public Image healthicon3;

	public Image livesicon1;
	public Image livesicon2;

	// Use this for initialization
	void Start () {
		spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isimmune == true) {
			SpriteFlicker();
			immunitytime = immunitytime = Time.deltaTime;
			if (immunitytime >= immuntyduration) {
				this.isimmune = false;
				this.spriteRenderer.enabled = true;
			}
		}
		
	}
	public void takedamage(int damage) {
		if (this.isimmune == false) {
			this.health = this.health - damage;
			if (this.health == 2)
			{
				Destroy(healthicon3);
			}
			else if (health == 1)
			{
				Destroy(healthicon2);
			}
			else {
				Destroy(healthicon1);
			}
			if (this.health < 0) {
				this.health = 0;
			}
			if (this.lives > 0 && this.health == 0) {
				//FindObjectOfType<lvlmanager>().RespawnPlayer();
				if (lives == 2) {
					this.health = 6;
					Destroy(this.livesicon1);
					this.lives--;
				} else if (lives == 1) {
					this.health = 6;
					Destroy(this.livesicon1);
					this.lives--;
				}
			} else if (this.lives == 0 && this.health == 0) {
				Debug.Log("gameover");
				Destroy(this.gameObject);
			}
			Debug.Log("player health:" + this.health.ToString());
			Debug.Log("player lives:" + this.lives.ToString());
		}
		PlayHitReaction();
	}
	void PlayHitReaction() {
		this.isimmune = true;
		this.immunitytime = 0f;
	}
	void SpriteFlicker() {
		if (this.flickertime < this.flickerduration) {
			this.flickertime = this.flickertime + Time.deltaTime;
		} else if (this.flickertime >= this.flickerduration) {
			spriteRenderer.enabled = !(spriteRenderer.enabled);
			this.flickertime = 0;
		}
	}
}
