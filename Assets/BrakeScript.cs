using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeScript : MonoBehaviour
{
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            for(int i=0; i > player.velocity.x; i++)
            {
                player.drag++;
            }
        }
    }
}
