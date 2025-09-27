using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.Impl;

public class AirPlaneScript : MonoBehaviour
{
    public GameObject freeBird;

    public coinScript coinScript;
    public TMP_Text scoreUi;

    [Header("Audio")]
    public AudioSource boomBox;
    public AudioClip freedBirdLoudAudioClip;
    public AudioClip freeBirdAudioClip;
    public float airTime;
    private float volumeControl;

    public float groundTime;
    
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        boomBox.clip = freeBirdAudioClip;
        volumeControl = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGrounded)
        {
            airTime += Time.deltaTime;
            boomBox.volume += Time.deltaTime * 0.08f;
            if (boomBox.volume >= 1f) {
                boomBox.volume = 1f;
                boomBox.clip = freedBirdLoudAudioClip;
                if (!boomBox.isPlaying)
                {
                    boomBox.Play();
                }
            }
            if(airTime >= 5)
            {
                coinScript.score += ((int)airTime)/200;
                string scoreString = coinScript.score.ToString();
                scoreUi.text = scoreString;
            }
        } 
        else
        {
            boomBox.clip = freeBirdAudioClip;
            boomBox.volume -= Time.deltaTime * 0.08f;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "terrain")
        {
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        airTime = 0;
    }
}
