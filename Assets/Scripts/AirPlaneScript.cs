using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlaneScript : MonoBehaviour
{
    public GameObject airPlane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "terrain")
        {
            airPlane.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        airPlane.SetActive(false);
    }
}
