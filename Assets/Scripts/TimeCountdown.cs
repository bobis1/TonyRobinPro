using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class TimeCountdown : MonoBehaviour
{
    public TextMeshProUGUI startCountdown;
    public TextMeshProUGUI lapTime;
    public CodeyMove player;


    public float totalLapTime;
    public float totalCountdownTime;
    public GameObject playerObj;
    // Start is called before the first frame update
    private void Start()
    {
        playerObj = GameObject.Find("Small child");
        player = playerObj.GetComponent<CodeyMove>();
        player.speed = 0f;
        Debug.Log("hehehhehehhehhehehe");
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

        if (totalCountdownTime > 0)
        {
            totalLapTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            player.speed = 0f;
        } else if (totalCountdownTime <= 0) {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            player.speed = 15f;

        }

        bool isLapUp = totalLapTime <= 0;
        if (isLapUp)
        {
            SceneManager.LoadScene(0);
        }
    }
}
