using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Note: Attach to main player

public class SloMoController : MonoBehaviour
{
    public float timer = 10.0f;
    public bool activated;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Time.timeScale = 0.65f;
            activated = true;
        }

        if (activated)
        {
            if (timer <= 0)
            {
                Time.timeScale = 1.0f;
                activated = false;
                timer = 10.0f;
            }

            timer -= Time.deltaTime;
        } 
    }
}
