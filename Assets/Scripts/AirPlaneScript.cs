using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AirPlaneScript : MonoBehaviour
{
    public GameObject freeBird;

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
