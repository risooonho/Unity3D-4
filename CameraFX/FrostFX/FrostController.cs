using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostController : MonoBehaviour
{
    private GameObject player;
    private FrostEffect playerScript;
    private const float coef = 0.1f; // TODO: Testing variable
    private bool detect = false;


    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("FPSCamera");
        this.playerScript = player.GetComponent<FrostEffect>();
        this.playerScript.FrostAmount = 0f; // TODO: Check for conflicting Start() scripts
    }


    // Update is called once per frame
    void Update()
    {
        if (detect)
        {
            // Upper bound frost value
            if (playerScript.FrostAmount > 0.5f)
                return;

            this.playerScript.FrostAmount += coef * Time.deltaTime;
            Debug.Log("Current frost value is " + playerScript.FrostAmount);
        }
    }

    // Trigger controller: On/Off switch
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Camera&Controller")
            detect = true;
        else
            detect = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Camera&Controller")
            detect = false;
        else
            detect = true;
    }
}
