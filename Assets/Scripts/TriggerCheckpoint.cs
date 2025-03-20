using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheckpoint : MonoBehaviour
{
    public int Checkpoints;
    public int TriggeredCheckpoints;

    // Start is called before the first frame update
    void Start()
    {
    
        Checkpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
