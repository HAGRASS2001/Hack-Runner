using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {
	public bool isfacingright = false;
	public float maxspeed = 3f;
	public int damage = 1;

	public void flip()
	{
		isfacingright = !isfacingright;
		transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);

	}




}

