using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class lastScore : MonoBehaviour
{
    public string score;
    public TMP_Text scoreUi;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetString("scoreString");
        scoreUi.text = score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
