using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody2D rigid;
    bool IsJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Jump();
    }

    public void Move()
    {

        float x = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(new Vector2(x * Time.deltaTime * 5, 0));
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsJump == true)
        {
            rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

            IsJump = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Stool")
        {
            IsJump = true; 
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("빨간색 진입");
        }
        if (collision.gameObject.tag == "Orange")
        {
            Debug.Log("주황색 진입");
        }
        if (collision.gameObject.tag == "Yellow")
        {
            Debug.Log("노랑색 진입");
        }
        if (collision.gameObject.tag == "Green")
        {
            Debug.Log("초록색 진입");
        }
        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("파랑색 진입");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("빨간색 나감");
        }
        if (collision.gameObject.tag == "Orange")
        {
            Debug.Log("주황색 나감");
        }
        if (collision.gameObject.tag == "Yellow")
        {
            Debug.Log("노랑색 나감");
        }
        if (collision.gameObject.tag == "Green")
        {
            Debug.Log("초록색 나감");
        }
        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("파랑색 나감");
        }
    }
}
