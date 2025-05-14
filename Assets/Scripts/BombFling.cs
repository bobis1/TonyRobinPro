using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            Object.Destroy(collision.gameObject);
            Object.Destroy(gameObject);
        }
    }
}
