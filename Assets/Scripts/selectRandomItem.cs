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
    //public float speed;
    public CodeyMove codeyMove;
    // Start is called before the first frame update
    void Start()
    {
        codeyMove = GetComponent<CodeyMove>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("The collision works");
        if(collision.gameObject.tag == "itemBox")
        {
            randomNumberInList = UnityEngine.Random.Range(0, powerupList.Count);
            powerUpSelected = powerupList[randomNumberInList];

            canUsePowerup = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnPosition.x = transform.position.x;
        spawnPosition.y = transform.position.y;
        spawnPosition.z = transform.position.z - 1;
        if (!canUsePowerup) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Key input works");
            if(powerUpSelected.type == PowerUpType.BigChild)
            {
                Instantiate(powerUpSelected, transform);
                Debug.Log("The speed should change now");
                codeyMove.speed = 100f;
                canUsePowerup = false;
                StartCoroutine(SetSpeedToNormal());
                //this.GetComponent<CodeyMove>().speed = 40f;

            }
            if (powerUpSelected.type == PowerUpType.Bomb) {

                Instantiate(powerUpSelected, spawnPosition, transform.rotation);
                canUsePowerup = false;

            }
            if (powerUpSelected.type == PowerUpType.Rocket) {

                Instantiate(powerUpSelected, spawnPosition, transform.rotation);
                canUsePowerup = false;

            }
        }
    }
     IEnumerator SetSpeedToNormal()
    {
        yield return new WaitForSeconds(30);
        //codeyMove.speed = 15f;
    }
}
