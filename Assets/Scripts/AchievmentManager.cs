using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentManager : MonoBehaviour
{
    public List<Achievement> achievementObjs = new List<Achievement>();

    Dictionary<string, bool> achivements = new Dictionary<string, bool>();



    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < achievementObjs.Count; i++)
        {
            achivements.Add(achievementObjs[i].name, achievementObjs[i].isCollected);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAchievement(string achievementName, bool isCollected)
    {
        achivements[achievementName] = isCollected;
    }

}
