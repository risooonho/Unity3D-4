using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Note: Attach to main player
public class SloMoController : MonoBehaviour
{
    public static float timer = 10.0f;
    public static bool activationFlag;
    public static AudioClip startSound;
    public static AudioClip endSound;

    // Update is called once per frame
    void Update()
    {
        // Gate it
        if(!activationFlag)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                AudioSource start = GetComponent<AudioSource>();
                start.clip = startSound;
                start.Play();

                Time.timeScale = 0.5f;
                activationFlag = true;   
            }
        }

        if(activationFlag)
        {
            if (timer <= 0)
            {
                // Intialize audio clip when timer runs out
                AudioSource end = GetComponent<AudioSource>();
                end.clip = endSound;
                end.Play();

                // Reset all values when timer runs out
                Time.timeScale = 1.0f;
                activationFlag = false;
                timer = 10.0f;
                Debug.Log(Time.timeScale);

            }

            // Timer countdown starts
            timer -= Time.deltaTime;
        } 
    }
}
