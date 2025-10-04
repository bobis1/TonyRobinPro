using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
//using UnityEngine.TestTools.Constraints;
public class CodeyMove : MonoBehaviour
{
    public float speed;
    public float playerJump = 10f;
    public bool running = false;
    public bool canMove = true;
    public bool isGrounded = false;
    public Vector3 move;
    public float _rotationSpeed = 50f;
    private Rigidbody rb;
    public Transform player;
    public float rotationSpeed = 10f;

    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        speed = 50f;
    }
    void FixedUpdate()
    {

        if (canMove)
        {

            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 rotation = new Vector3(0, horizontal * _rotationSpeed * Time.deltaTime, 0);
            move = transform.forward * speed * Time.deltaTime * vertical;
            transform.Rotate(rotation);
            rb.AddForce(move, ForceMode.VelocityChange);

            //anim.SetBool("isRunning", move != Vector3.zero);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                rb.AddForce(transform.up * playerJump, ForceMode.Impulse);
            }
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}