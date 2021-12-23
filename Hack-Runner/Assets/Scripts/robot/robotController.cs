using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotController : MonoBehaviour
{
    public float movespeed;
    public bool isfacingright;
    //public KeyCode leftarrow;
    //public KeyCode rightarrow;
    public KeyCode attack2;
    private Animator anim;
    public float minDistance;
    private playercontroller player;
    private bool runcondition;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playercontroller>();
        isfacingright = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        runcondition = true;
        if (Vector3.Distance(transform.position, player.transform.position) > minDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
            runcondition = false;
        }
        anim.SetBool("runcheck", runcondition);
        flip();
        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
        //Attack();
        //if (Input.GetKey(leftarrow))
        //{
        //    GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
        //    if (isfacingright)
        //    {
        //        flip();
        //        isfacingright = false;
        //    }
        //}
        //if (Input.GetKey(rightarrow))
        //{

        //    GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
        //    if (!isfacingright)
        //    {
        //        flip();
        //        isfacingright = true;
        //    }
        //}

    }
    //void Attack()
    //{
    //    if (Input.GetKey(attack2))
    //    {
    //        anim.SetBool("attack", true);
    //        StartCoroutine(WaitForHalfASecond());
    //    }
    //}
    //IEnumerator WaitForHalfASecond()
    //{
    //    yield return new WaitForSeconds(1);
    //    anim.SetBool("attack", false);
    //}
    void flip()
    {
        if (FindObjectOfType<playercontroller>().isfacingright != isfacingright) {
            isfacingright = FindObjectOfType<playercontroller>().isfacingright;
            transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
}
