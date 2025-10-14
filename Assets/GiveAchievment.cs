using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GiveAchievment : MonoBehaviour
{
    [SerializeField] private int achievementToGive;
    [SerializeField ]private string[] names = { "Touch Box", "get 10000 score", "freeBird!!!", "go to the hole"}; 
    Dictionary<string, bool> achivements = new Dictionary<string, bool>();

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < names.Length; i++) {
            achivements.Add(names[i], false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString(names[achievementToGive] , achivements["Touch Box"].ToString());
            if (names[achievementToGive] == "Touch Box") {
                Debug.Log("");
            }
        }

    }
}
