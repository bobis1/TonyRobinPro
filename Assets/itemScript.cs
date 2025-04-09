using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class itemScript : MonoBehaviour
{
    public GameObject itemBox;
    public int numberOfBoxes;

    public int modifyXposition;
    public int modifyZposition;
    public int modifyYposition;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
             GameObject itemBoxClone = Instantiate(itemBox, new Vector3(
                 transform.position.x + modifyXposition * i,
                 transform.position.y+ modifyYposition,
                 transform.position.z + modifyZposition * i
                 ), 
                 transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
