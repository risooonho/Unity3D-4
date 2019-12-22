using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Note: Attach to main player
public class SloMoController : MonoBehaviour
{
    public float timer = 5.0f;
    public bool activationFlag;
    public AudioClip startSound;
    public AudioClip endSound;
    public Slider instinctSlider; // Make sure to build canvas w/ slider

    // Update is called once per frame
    void Update()
    {
        // Gate it
        if(!activationFlag)
        {
            // Update instinct meter charge here
            instinctSlider.value += .005f;
            timer = instinctSlider.value;


            if(Input.GetKeyDown(KeyCode.F))
            {
                AudioSource start = GetComponent<AudioSource>();
                start.clip = startSound;
                start.Play();

                Time.timeScale = 0.6f; // Frame rate when activated
                activationFlag = true;   
            }
        }

        if(activationFlag)
        {
            // Update instinct slider
            instinctSlider.value = timer;

            if (timer <= 0)
            {
                // Intialize audio clip when timer runs out
                AudioSource end = GetComponent<AudioSource>();
                end.clip = endSound;
                end.Play();

                // Reset all values when timer runs out
                Time.timeScale = 1.0f;
                activationFlag = false;
                

                Debug.Log(Time.timeScale);
            }
            // Timer countdown starts
            timer -= Time.deltaTime;
            
        } 
    }
}
