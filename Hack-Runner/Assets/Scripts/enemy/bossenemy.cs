﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossenemy : enemyController
{
    private Animator anim;
    private float flickertime = 0f;
    public float flickerduration = 0.1f;
    private SpriteRenderer spriterenderer;
    public bool isimmune = false;
    private float immunitytime = 0f;
    public float immunityduration = 1.5f;
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
        spriterenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
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
        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "wall")
        {
            flip();
        }
        if (other.tag == "Player")
        {
            flip();
            attack();
            Invoke("flip", 3);
            FindObjectOfType<playerstats>().takedamage(damage);
        }
        if (other.gameObject.tag == "playerkick")
        {
            takedamage(1);
        }
    }
    public void takedamage(int damage)
    {
        if (this.isimmune == false)
        {
            if (bosshealth == 10)
            {
                bosshealth--;
                Destroy(healthicon10);
            }
            else if (bosshealth == 9)
            {
                bosshealth--;
                Destroy(healthicon9);
            }
            else if (bosshealth == 8)
            {
                bosshealth--;
                Destroy(healthicon8);
            }
            else if (bosshealth == 7)
            {
                bosshealth--;
                Destroy(healthicon7);
            }
            else if (bosshealth == 6)
            {
                bosshealth--;
                Destroy(healthicon6);
            }
            else if (bosshealth == 5)
            {
                bosshealth--;
                Destroy(healthicon5);
            }
            else if (bosshealth == 4)
            {
                bosshealth--;
                Destroy(healthicon4);
            }
            else if (bosshealth == 3)
            {
                bosshealth--;
                Destroy(healthicon3);
            }
            else if (bosshealth == 2)
            {
                bosshealth--;
                Destroy(healthicon2);
            }
            else if (bosshealth == 1)
            {
                bosshealth--;
                Destroy(healthicon1);
                Destroy(this.gameObject);
            }
        }
        enemyhitreaction();
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
    void enemyhitreaction()
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
