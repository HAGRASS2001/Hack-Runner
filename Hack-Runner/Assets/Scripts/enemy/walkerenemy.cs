using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkerenemy : enemyController {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate() {
		if (this.isfacingright == true)
		{
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxspeed, this.GetComponent<Rigidbody2D>().velocity.y);
		}
		else {
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxspeed, this.GetComponent<Rigidbody2D>().velocity.y);
		}
			
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "wall")
		{
			flip();
		}
		else if (other.tag == "enemy")
		{
			flip();
		}
		if (other.tag == "Player")
		{
			FindObjectOfType<playerstats>().takedamage(damage);
			flip();
		}
	}
}
