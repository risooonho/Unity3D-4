using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Apply to warm-zone box collider
// Note: Make sure FrostEffect is applied to the camera

public class WarmController : MonoBehaviour
{
    private bool detect;
    private const float coefficient = 0.1f; // Testing value

    private GameObject player;
    private FrostEffect playerScript;


    void Start()
    {
        this.player = GameObject.Find("FPSCamera");
        this.playerScript = player.GetComponent<FrostEffect>();
        this.playerScript.FrostAmount = 0f; // Initialize lens script on start
    }

    // Update is called once per frame
    void Update()
    {
        // Adjust for testing - lower bound limit
        if (detect)
        {
            if (playerScript.FrostAmount < 0f)
                return;

            this.playerScript.FrostAmount -= coefficient * Time.deltaTime;
            Debug.Log("Current frost value is at: " + playerScript.FrostAmount);
        }   
    }

    // On helper
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Camera&Controller")
            detect = true;
        else
            detect = false;
    }

    // Off helper
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Camera&Controller")
            detect = false;
        else
            detect = true;   
    }
}
