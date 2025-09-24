using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public GameObject backCamera;
    public GameObject frontCamera;
    public GameObject currentCam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
                currentCam.SetActive(false);
                currentCam = frontCamera;
                currentCam.SetActive(true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
                            currentCam.SetActive(false);
                currentCam = backCamera;
                currentCam.SetActive(true);
        }
    }
}
