using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Vector3 impulse = new Vector3(100.0f, 300.0f, 0.0f);
    private Rigidbody rb;
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ps = GetComponent<ParticleSystem>();
        rb.AddForce(impulse, ForceMode.Impulse);
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        ps.Stop();

        if (collision.gameObject.tag == "Obstacle")
        {
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}


