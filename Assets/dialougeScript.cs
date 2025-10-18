using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialougeScript : MonoBehaviour
{
    public TextMeshProUGUI dialougeBox;
    public GameObject dialougeCanvas;

    public GameObject backgroundCanvas;
    public string dialouge;
    // Start is called before the first frame update
    void Start()
    {
        dialougeBox.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            backgroundCanvas.SetActive(true);
            dialougeCanvas.SetActive(true);
            dialougeBox.text = dialouge;
        }
    }
    void OnTriggerExit(Collider other)
    {
        backgroundCanvas.SetActive(false);
        dialougeCanvas.SetActive(false);
    }
}
