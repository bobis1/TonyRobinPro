using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToMapSelect : MonoBehaviour
{
    public bool isOnMapSelect;
    public GameObject startCanvas;
    public GameObject mapSelectCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void switchToMapSelect()
    {
        if (!isOnMapSelect)
        {
            startCanvas.SetActive(false);
            mapSelectCanvas.SetActive(true);
        }
    }
}
