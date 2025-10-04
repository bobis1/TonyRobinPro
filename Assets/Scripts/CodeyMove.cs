using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;
using Unity.Mathematics;
using System.Net.NetworkInformation;
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
    public float bottomClamp;
    public float topClamp;

    private bool isCursorLocked;
    private float cinemachineTargetPitch;
    private float cinemachineTargetYaw;

    private void LateUpdate()
    {
        CameraLogic();
    }
    private void CameraLogic()
    {
        float mousex = GetMouseInput("Mouse X");
        float mousey = GetMouseInput("Mouse Y");

        cinemachineTargetPitch = UpdateRotation(cinemachineTargetPitch, mousey, bottomClamp, float.MaxValue, true);
        cinemachineTargetYaw = UpdateRotation(cinemachineTargetYaw, mousex, float.MinValue, float.MaxValue, false);
        ApplyRotations(cinemachineTargetPitch, cinemachineTargetYaw);

    }
    private void ApplyRotations(float pitch, float yaw)
    {
        player.transform.rotation = Quaternion.Euler(pitch, yaw, player.eulerAngles.z);
    }
    private float UpdateRotation(float currentRotation, float input, float min, float max, bool isXAxis)
    {
        currentRotation += isXAxis ? -input : input;
        return Mathf.Clamp(currentRotation, min, max);
    }

        private float GetMouseInput(string axis)
    {
        return Input.GetAxis(axis) * rotationSpeed * Time.deltaTime;
    }

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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (isCursorLocked)
            {
                Cursor.lockState = CursorLockMode.None;
                isCursorLocked = false;
            }
            else if (!isCursorLocked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                isCursorLocked = true;
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