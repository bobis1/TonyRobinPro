using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BrakeScript : MonoBehaviour
{
    public float increment;
    public Rigidbody playerRb;

    public TMP_Text drag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            playerRb.drag += increment;
        }
        if (Input.GetKey(KeyCode.F))
        {
            if (playerRb.drag >= 0)
            {
                playerRb.drag -= increment;
            }
        }
        drag.text = playerRb.drag.ToString();

    }

    public void resetDrag()
    {
        playerRb.drag = 0.35f;
    }
}

