using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movespeed;
    public float jumphieght;
    public bool isfacingright;
    public KeyCode spacebar;
    public KeyCode leftarrow;
    public KeyCode rightarrow;
    public KeyCode kick;
    public Transform groundcheck;
    public float groundcheckradius;
    public LayerMask whatisground;
    private bool grounded;
    private Animator anim;
    private bool kickornot;
    // Start is called before the first frame update
    void Start()
    {
        isfacingright = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(kick))
        {
            kickornot = true;

        }
        anim.SetBool("kickornot", kickornot);
        if (Input.GetKey(spacebar) && grounded)
        {
            jump();
        }
        anim.SetBool("grounded", grounded);
        if (Input.GetKey(leftarrow)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
            if (isfacingright)
            {
                flip();
                isfacingright = false;
            }
        }
        if (Input.GetKey(rightarrow))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);
            if (!isfacingright)
            {
                flip();
                isfacingright = true;
            }
        }
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }
    void flip()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumphieght);
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, whatisground);
    }
}
