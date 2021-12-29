using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossenemy : enemyController
{
    public int bosshealth = 5;
    public int lives = 2;
    private Animator anim;
    private float flickertime = 0f;
    public float flickerduration = 0.1f;
    private SpriteRenderer spriterenderer;
    public bool isimmune = false;
    private float immunitytime = 0f;
    public float immunityduration = 1.5f;
    private GameObject returnflip;
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
    public GameObject liveicon1;
    public GameObject liveicon2;
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
        if (other.tag == "flip") {
            flip();
            returnflip =  other.gameObject;
            returnflip.SetActive(false);
        }
        if (other.tag == "returnflip") {
            returnflip.SetActive(true);
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
            if (lives == 2)
            {
                if (bosshealth == 5)
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
                    lives--;
                    Destroy(healthicon1);
                    Destroy(liveicon1);
                    bosshealth = 5;
                }
            }
            else if (lives == 1)
            {
                if (bosshealth == 5)
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
                    lives--;
                    Destroy(healthicon1);
                    Destroy(liveicon2);
                }
            }
            else if(lives == 0) {
                Destroy(this.gameObject);
                Destroy(FindObjectOfType<playercontroller>().gameObject.GetComponent<hackscenescript>().audiolvl3);
                SceneManager.LoadScene(12);
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
