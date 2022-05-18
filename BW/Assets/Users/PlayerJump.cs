using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    private BoxCollider2D col;

    private const float jump = 160f;

    [SerializeField, Range(1, 6)]
    private float jumpForce = 1;
    [SerializeField, Range(1, 6)]
    private float moveSpeed = 1;
    private int mycolor;
    private Collision2D obj = null;

    private int jumpCount = 0;

    private bool floorFrag = true;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& this.jumpCount < 1)
        {
            this.rbody2D.AddForce(transform.up * jump*jumpForce);
            jumpCount++;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Time.deltaTime*2*moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime*2*moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift)||Input.GetKeyDown(KeyCode.W))
        {
            mycolor = (int)GetComponent<SpriteRenderer>().color.r;
            Debug.Log(mycolor);
            GetComponent<SpriteRenderer>().color = new Color((1 - mycolor), (1 - mycolor), (1 - mycolor));
            
        }


    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        obj = collision;
        if (obj.gameObject.GetComponent<SpriteRenderer>().color.r + GetComponent<SpriteRenderer>().color.r == 1)
        {//自分と色が違うなら
            Debug.Log("色が違う");
            obj.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            //それの判定をなくす
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {//触れたとき

            obj = collision;
            if(obj.gameObject.GetComponent<SpriteRenderer>().color.r+ GetComponent<SpriteRenderer>().color.r==1)
            {//自分と色が違うなら
                Debug.Log("色が違う");
                obj.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                //それの判定をなくす
            }
            else
            {

                jumpCount = 0;
                if (collision.gameObject.CompareTag("MoveFloor"))
                {//動く床なら
                   
                    transform.SetParent(collision.transform);
                
                }
            }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("MoveFloor"))
        {//動く床なら

            transform.SetParent(null);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.GetComponent<SpriteRenderer>().color.r == GetComponent<SpriteRenderer>().color.r)
        {
            col.isTrigger = false;
            jumpCount = 0;
        }
    }

    */
}
