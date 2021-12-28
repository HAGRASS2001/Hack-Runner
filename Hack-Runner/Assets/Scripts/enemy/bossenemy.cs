using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossenemy : enemyController
{
    private Animator anim;
    public GameObject healthicon1;
    public GameObject healthicon2;
    public GameObject healthicon3;
    public GameObject healthicon4;
    public GameObject healthicon5;
    public GameObject healthicon6;
    public GameObject healthicon7;
    public GameObject healthicon8;
    public GameObject healthicon9;
    public GameObject healthicon10;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "wall")
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
            if (bosshealth == 10)
            {
                bosshealth--;
                Destroy(healthicon10);
            }
            else if (bosshealth == 9)
            {
                Destroy(healthicon9);
            }
            else if (bosshealth == 8)
            {
                Destroy(healthicon8);
            }
            else if (bosshealth == 7)
            {
                Destroy(healthicon7);
            }
            else if (bosshealth == 6)
            {
                Destroy(healthicon6);
            }
            else if (bosshealth == 5)
            {
                Destroy(healthicon5);
            }
            else if (bosshealth == 4)
            {
                Destroy(healthicon4);
            }
            else if (bosshealth == 3)
            {
                Destroy(healthicon3);
            }
            else if (bosshealth == 2)
            {
                Destroy(healthicon2);
            }
            else if (bosshealth == 1)
            {
                Destroy(healthicon1);
            }
        }
    }

    void FixedUpdate()
    {
        if (this.isfacingright == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxspeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxspeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void attack()
    {
        anim.SetBool("attack", true);
        StartCoroutine(WaitForHalfASecond());
    }
    IEnumerator WaitForHalfASecond()
    {
        yield return new WaitForSeconds(0.75F);
        anim.SetBool("attack", false);
    }

}
