using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 30);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Console.WriteLine("Items collected");
        }
    }

}
