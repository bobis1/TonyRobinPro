using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Achievement : MonoBehaviour
{
    public string achievementName;
    public bool isCollected;
    public Sprite image;
    public Sprite nonCollectedImage;

    private Image display; 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        if (isCollected)
        {
            display.sprite = image;
        }
        else
        {
            display.sprite = nonCollectedImage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
