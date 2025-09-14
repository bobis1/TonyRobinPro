using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject[] Objects;
    public GameObject player;

    public bool isMenuOpen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isMenuOpen == false)
            {
            menu.SetActive(true);
            isMenuOpen = true;
            }
        else if (isMenuOpen == true)
            {
            menu.SetActive(false);
            isMenuOpen = false;
            }
        }
    }
    public void SpawnMenuOpen()
    {
        if (isMenuOpen == false)
        {
            menu.SetActive(true);
            isMenuOpen = true;
        }
        else if (isMenuOpen == true)
        {
            menu.SetActive(false);
            isMenuOpen = false;
        }
    }
    public void Barrel()
    {
        GameObject obj = Objects[0];
        Instantiate(obj, player.transform.position, player.transform.rotation);
        obj.SetActive(true);
    }
}
