using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class AchievmentManager : MonoBehaviour
{
    public List<Achievement> achievements = new List<Achievement>();


    public bool deletePrefs = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (deletePrefs)

        {
            DeletePlayerPrefs();
            deletePrefs = false;
        }
    }

    public void UnlockAchievment(Achievement achievement)
    {
        achievement.isCollected = true;
        Save();
    }
    public void Save()
    {
        for(int i = 0; i < achievements.Count; i++)
        {
            PlayerPrefs.SetInt(achievements[i].name, ConvertBoolToInt(achievements[i].isCollected));
        }
        PlayerPrefs.Save();
    }

    public void Load() {
        for (int i = 0; i < achievements.Count; i++)
        {
            achievements[i].isCollected = ConvertIntToBool(PlayerPrefs.GetInt(achievements[i].name));
        }
    }


    private int ConvertBoolToInt(bool b)
    {
        return (b ? 1 : 0);
    }

    private bool ConvertIntToBool(int i)
    {
        return (i == 0 ? false : true);
    }

    public void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
