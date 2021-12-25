using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkerenemy : enemyController {
	private playercontroller Player;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		Player = FindObjectOfType<playercontroller>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, maxspeed * Time.deltaTime);

		if (Player.transform.position.x < gameObject.transform.position.x && isfacingright)
			flip();

		if (Player.transform.position.x > gameObject.transform.position.x && !isfacingright)
			flip();

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
