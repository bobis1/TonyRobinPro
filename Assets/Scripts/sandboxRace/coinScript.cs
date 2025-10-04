using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class coinScript : MonoBehaviour
{
    public int score;
    public TMP_Text scoreUi;
    // Start is called before the first frame update
        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            score +=1000;
            Destroy(collision.gameObject);
            string scoreString = score.ToString();
            scoreUi.text = scoreString;
        }
    }
}
