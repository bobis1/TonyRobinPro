using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uprightScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            resetRotation();
        }
    }
    public void resetRotation()
    {
        playerPosition = player.transform.position;
        playerPosition.y += 10;
        player.transform.position = playerPosition;
        player.transform.rotation = Quaternion.identity;
    }
 
}
