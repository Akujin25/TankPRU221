using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undying : setUpMap
{
    float time = 0;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 3)
        {
            gameObject.SetActive(false);
            undying.isundying = false;
        }
    }
}
