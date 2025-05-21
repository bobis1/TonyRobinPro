using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectRandomItem : MonoBehaviour
{
    public List<PowerUp> powerupList;
    public int randomNumberInList;
    public PowerUp powerUp;
    public Vector3 spawnPosition;
    public GameObject powerUpSelectingType;
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
            powerUpSelectingType = powerupList[randomNumberInList].gameObject;
            Debug.Log("Tag detection works");
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Key input works");
            if(powerUp.type == PowerUpType.BigChild)
            {
                Instantiate(powerUpSelectingType, transform);
            }
            if (powerUp.type == PowerUpType.Bomb) {
                Instantiate(powerUpSelectingType, spawnPosition, transform.rotation);
            }
            if (powerUp.type == PowerUpType.Rocket) {

                Instantiate(powerUpSelectingType, spawnPosition, transform.rotation);
            }
        }
    }
}
