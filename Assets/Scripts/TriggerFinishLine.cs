using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("The trigger works");
        if (other.gameObject.tag == "Player")
        {
            print("You Win!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
