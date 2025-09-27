using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class timerSandboxScript : MonoBehaviour
{
    public TextMeshProUGUI timerUI;
    public GameObject[] coins;
    public TMP_Text scoreUi;

    public coinScript scoreScript;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("coin");
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreScript.score == coins.Length)
        {
            if (timer >= 60)
            {
                scoreScript.score = scoreScript.score * 2;
                string scoreString = scoreScript.score.ToString();
                scoreUi.text = scoreString;
                if (timer >= 70)
                {
                    scoreScript.score = scoreScript.score * 4;
                    scoreUi.text = scoreString;
                }
            }
        }
        timer -= Time.deltaTime;
        string timerString = timer.ToString();
        timerUI.text = timerString;
    }
}
