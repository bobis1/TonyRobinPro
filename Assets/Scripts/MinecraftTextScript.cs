using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;

public class MinecraftTextScript : MonoBehaviour
{
    public TextMeshProUGUI minecraftText;
    public string[] text;
    // Start is called before the first frame update
    void Start()
    {
        minecraftText.text = text[Mathf.RoundToInt(UnityEngine.Random.Range(0, 10))];
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 52;i <= minecraftText.fontSize; i++)
        {
            minecraftText.fontSize++;
        }
    }
    void randomFontSize()
    {
        
    }
}
