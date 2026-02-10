using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Hoop : MonoBehaviour
{
    public coinScript coinScript;
    public TMP_Text scoreUi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        coinScript.score += 1000;
        string scoreString = coinScript.score.ToString();
        scoreUi.text = scoreString;
        PlayerPrefs.SetString("scoreString", scoreString);
    }
}
