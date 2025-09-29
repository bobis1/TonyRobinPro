using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trickScript : MonoBehaviour
{
    public bool isTricking;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            isTricking = true;
            transform.Rotate(Vector3.forward, Time.deltaTime * 30);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            isTricking = false;
            transform.rotation = Quaternion.identity;
        }
    }


}
