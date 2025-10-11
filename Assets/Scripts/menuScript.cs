using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public bool isOnMapSelect = false;
    public GameObject startCanvas;
    public GameObject mapSelectCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public  void loadSunny()
    {
        SceneManager.LoadScene(1);
    }
   public  void loadMount()
    {
        SceneManager.LoadScene(2);
    }
    public void loadObelisk()
    {
        SceneManager.LoadScene(3);
    }

        public void switchToMapSelect()
    {
        if (!isOnMapSelect)
        {
            startCanvas.SetActive(false);
            mapSelectCanvas.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
