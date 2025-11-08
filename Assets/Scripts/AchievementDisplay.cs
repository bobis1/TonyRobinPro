using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AchievementDisplay : MonoBehaviour
{
    public Achievement achievment;
    public Sprite image;
    public Sprite nonCollectedImage;

    public UnityEngine.UI.Image display; 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (achievment.isCollected)
        {
            Debug.Log("Is Collected");
            display.sprite = image;
        }
        else
        {
            Debug.Log("Is not collected");
            display.sprite = nonCollectedImage;
        }
    }
}
