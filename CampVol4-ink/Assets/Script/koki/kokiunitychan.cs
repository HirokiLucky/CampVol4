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

public class kokiunitychan : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    [SerializeField] private unitychanStatus status;
    //[SerializeField] private TextMeshProUGUI gameOverText;
    
    private float speed = 10.0f;
    private float gravityPower = -1000f;
    private float jumpPower = 1000f;
    
    private directions d = directions.right;
    [NonSerialized] public bool isGround = true;
    private bool gravityBool = true;
    private Vector3 prevPosition;
    
    private static readonly int Speed = Animator.StringToHash("speed");
    private static readonly int Jump = Animator.StringToHash("jump");
    private static readonly int JumpSpeed = Animator.StringToHash("jumpSpeed");

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        //gameOverText.text = status.hp.ToString();
    }

    //Update is called once per frame
    void Update()
    {
        Move();
        JumpCheck();
    }

    private void FixedUpdate()
    {
        if (gravityBool)
        {
            Gravity();
        }
        float x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector3(x, rb.velocity.y, 0);
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetInteger(Speed, 2);
            speed = 15.0f;
            if (d == directions.left)
            {
                d = directions.right;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        } else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger(Speed, 1);
            speed = 10.0f;
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
            speed = 10.0f;
            if (d == directions.right)
            {
                d = directions.left;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        } else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger(Speed, 1);
            speed = 10.0f;
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

        if (status.star >= 5)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                status.star -= 5;
                var ex = GameObject.Find("FlameThrower");
                var col = ex.GetComponent<CapsuleCollider>();
                col.enabled = true;
                Invoke(nameof(DelayFlame), 2f);
                var skill = ex.GetComponent<ParticleSystem>();
                skill.Play();
            }
        }
        if (status.star >= 1)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                status.star -= 1;
                var ex = GameObject.Find("OrbitalBeamPurple");
                var col = ex.GetComponent<BoxCollider>();
                Invoke(nameof(DelayOrbitalStart), 2f);
                Invoke(nameof(DelayOrbitalFinish), 2.7f);
                var orbital = ex.GetComponent<ParticleSystem>();
                orbital.Play();
            }
        }
    }
    
    void DelayFlame()
    {
        var ex = GameObject.Find("FlameThrower");
        var col = ex.GetComponent<CapsuleCollider>();
        col.enabled = false;
    }
    
    void DelayOrbitalStart()
    {
        var ex = GameObject.Find("OrbitalBeamPurple");
        var col = ex.GetComponent<BoxCollider>();
        col.enabled = true;
    }
    
    void DelayOrbitalFinish()
    {
        var ex = GameObject.Find("OrbitalBeamPurple");
        var col = ex.GetComponent<BoxCollider>();
        col.enabled = false;
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
            //gameOverText.text = "Game Over";
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
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Atmos"))
        {
            gravityBool = false;
            rb.useGravity = false;
        }

        if (other.gameObject.CompareTag("Star"))
        {
            status.star++;
        }

        if (other.gameObject.CompareTag("Mob"))
        {
            status.hp -= 1;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Atmos"))
        {
            gravityBool = true;
            rb.useGravity = true;
        }
    }
}
