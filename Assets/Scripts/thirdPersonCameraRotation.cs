using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonCameraRotation : MonoBehaviour
{
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

        cinemachineTargetPitch = GetRotation(cinemachineTargetPitch, mousey, bottomClamp, float.MaxValue, true);
        cinemachineTargetYaw = GetRotation(cinemachineTargetYaw, mousex, float.MinValue, float.MaxValue, false);
        ApplyRotations(cinemachineTargetPitch, cinemachineTargetYaw);

    }
    private void ApplyRotations(float pitch, float yaw)
    {
        player.transform.rotation = Quaternion.Euler(pitch, yaw, player.eulerAngles.z);
    }
    private float GetRotation(float currentRotation, float input, float min, float max, bool isXAxis)
    {
        currentRotation += isXAxis ? -input : input;
        return Mathf.Clamp(currentRotation, min, max);
    }

    private float GetMouseInput(string axis)
    {
        return Input.GetAxis(axis) * rotationSpeed * Time.deltaTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
