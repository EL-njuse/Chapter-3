//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class enemyFrog : MonoBehaviour
//{
//    private Rigidbody2D rb;
//    public Transform leftpoint, rightpoint;
//    private float leftx, rightx;
//    public float speed;
//    private bool faceLeft = true;
//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        transform.DetachChildren();
//        leftx = leftpoint.position.x;
//        rightx = rightpoint.position.x;
//        Destroy(leftpoint.gameObject);
//        Destroy(rightpoint.gameObject);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Movement();
//    }

//    void Movement()
//    {
//        if (faceLeft)
//        {
//            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
//            if (transform.position.x < leftx)
//            {
//                transform.localScale = new Vector3(-1, 1, 1);
//                faceLeft = false;
//            }
//        }
//        else
//        {
//            rb.velocity = new Vector2(speed, rb.velocity.y);
//            if (transform.position.x > rightx)
//            {
//                transform.localScale = new Vector3(1, 1, 1);
//                faceLeft = true;
//            }
//        }
//    }
//}
