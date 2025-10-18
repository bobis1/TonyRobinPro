using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialougeScript : MonoBehaviour
{
    public TextMeshPro dialougeBox;
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
        dialougeBox.text = dialouge;
    }
    void OnTriggerExit(Collider other)
    {
        dialougeBox.text = "";
    }
}
