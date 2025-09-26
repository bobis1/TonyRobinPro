using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class timerSandboxScript : MonoBehaviour
{
    public TextMeshProUGUI timerUI;
    public GameObject[] coins;

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
                if (timer >= 70)
                {
                    scoreScript.score = scoreScript.score * 4;
                }
            }
        }
        timer -= Time.deltaTime;
    }
}
