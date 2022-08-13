using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerMove : MonoBehaviour
{
    public SpriteRenderer PlayerFilp;
    public Animator UFO;
    Rigidbody2D rigid;
    bool IsJump = true;

    bool CameraAnime = false;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameMng.GetIns.GameStart)
        Move();

        //Jump();
    }

    public void Move()
    {

        float x = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(new Vector2(x * Time.deltaTime * 5, 0));
        if (x > 0) PlayerFilp.flipX = true;
        if (x < 0) PlayerFilp.flipX = false;
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
        if (collision.gameObject.tag == "UFO" && !CameraAnime)
        {
            UFO.SetBool("IsUFO", true);
            Debug.Log("fd");
            CameraAnime = true;
            GameMng.GetIns.CameraPlayerView = false;
            GameMng.GetIns.CameraUFOView = true;
            Invoke("OnPlayerCamera",2.5f);

        }


        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("������ ����");
        }
        if (collision.gameObject.tag == "Orange")
        {
            Debug.Log("��Ȳ�� ����");
        }
        if (collision.gameObject.tag == "Yellow")
        {
            Debug.Log("����� ����");
        }
        if (collision.gameObject.tag == "Green")
        {
            Debug.Log("�ʷϻ� ����");
        }
        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("�Ķ��� ����");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("������ ����");
        }
        if (collision.gameObject.tag == "Orange")
        {
            Debug.Log("��Ȳ�� ����");
        }
        if (collision.gameObject.tag == "Yellow")
        {
            Debug.Log("����� ����");
        }
        if (collision.gameObject.tag == "Green")
        {
            Debug.Log("�ʷϻ� ����");
        }
        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("�Ķ��� ����");
        }
    }
    void OnPlayerCamera()
    {
        GameMng.GetIns.CameraPlayerView = true;
        GameMng.GetIns.CameraUFOView = false;;
    }
}
