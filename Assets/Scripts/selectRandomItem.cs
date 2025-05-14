using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectRandomItem : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("The collision works");
        if(collision.gameObject.tag == "itemBox")
        {
            randomNumberInList = UnityEngine.Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
                 Debug.Log("Tag detection works");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Key input works");
            if(randomNumberInList == 2)
            {
                Instantiate(chosenPowerup, transform);
            }
        }
    }
}
