using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointcollision : MonoBehaviour
{
    public bool didCollide;
    // Start is called before the first frame update
    void Start()
    {
        didCollide = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        didCollide = true;
    }

    // Update is called once per frame

}
