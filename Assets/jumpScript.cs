using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpScript : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.rigidbody.AddForce(0f, jumpForce, 0f);
            Invoke("Teleport", 5.0f);
        }
    }
    void Teleport()
    {
        SceneManager.LoadScene(4);
    }
}
