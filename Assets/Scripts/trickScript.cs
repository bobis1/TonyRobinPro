using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class trickScript : MonoBehaviour
{
    public bool isTricking;
    public GameObject player;
    public FreeBird GroundedScript;
    public float totalRot;
    public Rigidbody rb;
    public TMP_Text scoreUi;
    public coinScript coinScript;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isTricking = true;
            rb.AddTorque(Vector3.left * 400 * Time.fixedDeltaTime, ForceMode.Force);
            print("Left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isTricking = true;
            // transform.Rotate(Vector3.back, Time.deltaTime * 40);
            rb.AddTorque(Vector3.right * 400 * Time.fixedDeltaTime, ForceMode.Force);
            print("Right");
        }
        if (Input.GetKey(KeyCode.UpArrow)) { 
            isTricking = true;
            rb.AddTorque(Vector3.up * 400 * Time.fixedDeltaTime, ForceMode. Force);
            print("Up");
        }
        if (Input.GetKey(KeyCode.DownArrow)) { 
            isTricking = true;
            rb.AddTorque(Vector3.down * 400 * Time.fixedDeltaTime, ForceMode.Force);
            print("Down");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            isTricking = false;
            transform.rotation = Quaternion.identity;
        }
        if (isTricking)
        {
            totalRot += rb.angularVelocity.y * Time.fixedDeltaTime;
            totalRot += rb.angularVelocity.x * Time.fixedDeltaTime;
            totalRot += rb.angularVelocity.z * Time.fixedDeltaTime;
            coinScript.score += Math.Abs(Mathf.RoundToInt(totalRot));
            string scoreString = coinScript.score.ToString();
            scoreUi.text = scoreString;
            PlayerPrefs.SetString("scoreString", scoreString);
        }

        


    }


}
