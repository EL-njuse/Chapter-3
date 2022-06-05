//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class playerControlled : MonoBehaviour
//{

//    private Rigidbody2D rb;
//    public Collider2D coll;
//    private Animator anim;
//    public float speed;
//    public float jumpforce;
//    public LayerMask ground;
//    public int cherry;
//    public Text CherryNum;
//    public bool isHurt;
//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        anim = GetComponent<Animator>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (!isHurt)
//        {
//            Movement();
//        }
//        SwitchAnim();
//    }

//    void Movement()
//    {
//        float horizontalmove = Input.GetAxis("Horizontal");
//        float facedircetion = Input.GetAxisRaw("Horizontal");

//        //turn left and turn right
//        if (horizontalmove != 0)
//        {
//            rb.velocity = new Vector2(horizontalmove * speed * Time.deltaTime, rb.velocity.y);
//            anim.SetFloat("running", Mathf.Abs(facedircetion));
//        }

//        //animater
//        if (facedircetion != 0)
//        {
//            transform.localScale = new Vector3(facedircetion, 1, 1);
//        }

//        //Jump
//        if (Input.GetButtonDown("Jump") && coll.IsTouchingLayers(ground))//have bug
//        {
//            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
//            anim.SetBool("jumping", true);
//        }


//    }
//    void SwitchAnim()
//    {
//        anim.SetBool("idle", false);
//        if (anim.GetBool("jumping"))
//        {
//            if (rb.velocity.y < 0)
//            {
//                anim.SetBool("jumping", false);
//                anim.SetBool("falling", true);
//            }
//        }
//        else if (isHurt)
//        {
//            anim.SetBool("hurt", true);
//            anim.SetFloat("running", 0);
//            if (Mathf.Abs(rb.velocity.x) < 0.1f)
//            {
//                anim.SetBool("hurt", false);
//                anim.SetBool("idle", true);
//                isHurt = false;
//            }

//        }
//        else if (coll.IsTouchingLayers(ground))
//        {

//            anim.SetBool("falling", false);
//            anim.SetBool("idle", true);

//        }
//    }
//    //collect things,use trigger
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.tag == "Collections")
//        {
//            Destroy(collision.gameObject);
//            cherry += 1;
//            CherryNum.text = cherry.ToString();
//        }
//    }
//    //kill enemy
//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.tag == "Enemy")
//        {
//            if (anim.GetBool("falling"))
//            {
//                Destroy(collision.gameObject);
//                rb.velocity = new Vector2(rb.velocity.x, (jumpforce * Time.deltaTime) / 5);
//                anim.SetBool("jumping", true);
//            }
//            else if (transform.position.x < collision.gameObject.transform.position.x)
//            {
//                rb.velocity = new Vector2(-6, rb.velocity.y);
//                isHurt = true;
//            }
//            else if (transform.position.x > collision.gameObject.transform.position.x)
//            {
//                rb.velocity = new Vector2(6, rb.velocity.y);
//                isHurt = true;
//            }

//        }
//    }
//}
