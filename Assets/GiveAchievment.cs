using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GiveAchievment : MonoBehaviour
{
    public AchievmentManager AchievementManager;
    public string achievementName;

    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            AchievementManager.UpdateAchievement(achievementName, true);

        }

    }
}
