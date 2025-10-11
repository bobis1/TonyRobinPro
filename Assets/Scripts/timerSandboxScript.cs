using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using System.Security;
using System.Threading;
using UnityEngine.SceneManagement;
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
        if (scoreScript.score == coins.Length * 1000)
        {
            int multiplier = 2;
            if (timer >= 60)
            {
                multiplier = 2;
            }
            if (timer >= 70)
            {
                multiplier = 4;
            }
            scoreScript.score = scoreScript.score * multiplier;
            string scoreString = scoreScript.score.ToString();
            scoreUi.text = scoreString;
            Invoke(nameof(goToMenu), 5.0f);
        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            string timerString = timer.ToString();
            timerUI.text = timerString;
        }

        if (timer < 0)
        {
            timer = 0;
        }
    }
    void goToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
