using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrWhaleAchievementGiver : MonoBehaviour
{
    // Start is called before the first frame update
    public AchievmentManager AchievementManager;
    public Achievement achievement;


    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            achievement.isCollected = true;
            AchievementManager.UnlockAchievment(achievement);
            Debug.Log(PlayerPrefs.GetString(achievement.achievementName));

        }
    }
       
    }
