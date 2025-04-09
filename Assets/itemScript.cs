using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class itemScript : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
             GameObject itemBoxClone = Instantiate(itemBox, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
