using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotController : MonoBehaviour
{
    public float movespeed;
    public bool isfacingright;
    public KeyCode leftarrow;
    public KeyCode rightarrow;
    public KeyCode attack2;
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
        Attack();
        if (Input.GetKey(leftarrow))
        {
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
        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }
    void Attack()
    {
        if (Input.GetKey(attack2))
        {
            anim.SetBool("attack", true);
            StartCoroutine(WaitForHalfASecond());
        }
    }
    IEnumerator WaitForHalfASecond()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("attack", false);
    }
    void flip()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
}
