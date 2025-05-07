using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public  void loadRace()
    {
        SceneManager.LoadScene(1);
    }
   public  void loadSandbox()
    {
        SceneManager.LoadScene(2);
    }
    public void loadBoss()
    {
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
