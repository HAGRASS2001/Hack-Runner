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
    // Start is called before the first frame update
    void Start()
    {
        isfacingright = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Kick();
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

    void Kick (){
            if (Input.GetKey(kick))
            {
                anim.SetBool("kick", true);
                StartCoroutine(WaitForHalfASecond());
            }
    }
    IEnumerator WaitForHalfASecond()
    {
        yield return new WaitForSeconds(1/32);
        anim.SetBool("kick", false);
    }
    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, whatisground);
    }
}
