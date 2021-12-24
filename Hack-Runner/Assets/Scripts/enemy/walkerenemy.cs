using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkerenemy : enemyController {
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
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
		if (other.tag == "enemy")
		{
			flip();
		}
		if (other.tag == "Player")
		{
			attack();
			FindObjectOfType<playerstats>().takedamage(damage);
			//flip();
		}
		if (other.gameObject.tag == "playerkick")
		{
			Destroy(this.gameObject, 0f);
		}
	}
	void attack()
	{
			anim.SetBool("attack", true);
			StartCoroutine(WaitForHalfASecond());
	}
	IEnumerator WaitForHalfASecond()
	{
		yield return new WaitForSeconds(.25F);
		anim.SetBool("attack", false);
	}
	void OnCollisionEnter2D(Collision2D other)
	{

	}
}
