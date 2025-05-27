using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectRandomItem : MonoBehaviour
{
    public List<PowerUp> powerupList;
    public int randomNumberInList;
    public PowerUp powerUpSelected;
    public Vector3 spawnPosition;
    public bool canUsePowerup;
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
            powerUpSelected = powerupList[randomNumberInList];
            spawnPosition.x = transform.position.x;
            spawnPosition.y = transform.position.y;
            spawnPosition.z = transform.position.z-1;
            canUsePowerup = true;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Key input works");
            if(powerUpSelected.type == PowerUpType.BigChild)
            {
                if (canUsePowerup == true)
                {
                    Instantiate(powerUpSelected, transform);
                    canUsePowerup = false;
                }
            }
            if (powerUpSelected.type == PowerUpType.Bomb) {
                if(canUsePowerup == true)
                {
                    Instantiate(powerUpSelected, spawnPosition, transform.rotation);
                    canUsePowerup = false;
                }
            }
            if (powerUpSelected.type == PowerUpType.Rocket) {
                if (canUsePowerup == true)
                {
                    Instantiate(powerUpSelected, spawnPosition, transform.rotation);
                    canUsePowerup = false;
                }
            }
        }
    }
}
