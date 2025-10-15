using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentShow : MonoBehaviour
{
    public GameObject touchBox;
    // Start is called before the first frame update
    void Start()
    {
        touchBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetString("Touch Box") == "true"){
            touchBox.SetActive(true);
        }
    }
}
