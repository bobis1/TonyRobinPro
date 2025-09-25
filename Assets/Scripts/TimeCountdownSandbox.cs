using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;



public class TimeCountdownSandbox : MonoBehaviour
{
    public TextMeshProUGUI startCountdown;
    public TextMeshProUGUI lapTime;

    public coinScript score;


    float totalLapTime;
    public float totalCountdownTime;
    public GameObject playerObj;
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        if(totalCountdownTime == 0)
        {
            Debug.Log("start");
            Console.WriteLine("start");
        }

        bool isLapUp = totalLapTime <= 0;
        if (isLapUp)
        {
            Debug.Log("timer up" + score);
        }
    }
}
