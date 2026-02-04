using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started by Kreslit");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            Debug.Log("Running...");
            timer = 0f;
        }
    }
}
