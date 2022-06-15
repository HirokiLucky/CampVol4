using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

enum directions
{ 
    right,
    left
}

public class unitychan : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    [SerializeField] private TextMeshProUGUI gameOverText;
    
    private float speed = 15.0f;
    private float gravityPower = -1000f;
    private float jumpPower = 1000f;
    
    private directions d = directions.right;
    [NonSerialized] public bool isGround = true;
    private Vector3 prevPosition;
    
    private static readonly int Speed = Animator.StringToHash("speed");
    private static readonly int Jump = Animator.StringToHash("jump");
    private static readonly int JumpSpeed = Animator.StringToHash("jumpSpeed");

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
        Move();
        JumpCheck();
    }

    private void FixedUpdate()
    {
        Gravity();
        float x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector3(x, rb.velocity.y, 0);
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetInteger(Speed, 2);
            speed = 20.0f;
            if (d == directions.left)
            {
                d = directions.right;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        } else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger(Speed, 1);
            speed = 15.0f;
            if (d == directions.left)
            {
                d = directions.right;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetInteger(Speed, 0);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetInteger(Speed, 2);
            speed = 20.0f;
            if (d == directions.right)
            {
                d = directions.left;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        } else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger(Speed, 1);
            speed = 15.0f;
            if (d == directions.right)
            {
                d = directions.left;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetInteger(Speed, 0);
        }
    }

    void JumpCheck()
    {
        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                isGround = false;
                animator.SetBool(Jump, true);
                rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            }
        }
    }
    
    void Gravity() {
        rb.AddForce(new Vector3(0, gravityPower, 0));
        if (!isGround) {
            if (rb.velocity.y < 0)
            {
                animator.SetBool(JumpSpeed, false);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            animator.SetBool(Jump, false);
        }
        
        if (collision.gameObject.CompareTag("GameOver"))
        {
            gameOverText.text = "Game Over";
        }
        
        if (collision.gameObject.CompareTag($"MoveFloor"))
        {
            isGround = true;
            animator.SetBool(Jump, false);
            transform.SetParent(collision.transform);
        }
    }
    
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("MoveFloor"))
        {
            transform.SetParent(null);
        }
    }
}
