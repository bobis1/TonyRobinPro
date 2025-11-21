using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCorrection : MonoBehaviour
{
    public GameObject player;

    private bool isRotating;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRotating) StartCoroutine(RotateImage());
    }

    IEnumerator RotateImage()
    {
        isRotating = true;
        float moveSpeed = 0.01f;
        float X = 4.614f;
        while (player.transform.rotation.x < X)
        {
            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, Quaternion.Euler(4.614f, player.transform.rotation.y, player.transform.rotation.z), moveSpeed * Time.time);
            yield return null;
        }
        player.transform.rotation = Quaternion.Euler(4.614f, player.transform.rotation.y, player.transform.rotation.z);
        yield return null;

        isRotating  = false;
    }
}
