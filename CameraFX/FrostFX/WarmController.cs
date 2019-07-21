using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmController : MonoBehaviour
{
    private GameObject player;
    private FrostEffect playerScript;
    private const float coef = 0.1f;
    private bool detect;

    // TODO: Collision detection implementation

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("FPSCamera");
        this.playerScript = player.GetComponent<FrostEffect>();
        this.playerScript.FrostAmount = 0f;
    }

    private void Update()
    {
        if (detect) 
        {

            // TODO: Adjust later for testing
            // Lower bound for frost limit 
            if (playerScript.FrostAmount < 0f)
                return;

            this.playerScript.FrostAmount -= coef * Time.deltaTime;    
            Debug.Log("Current frost value is " + playerScript.FrostAmount);  
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Camera&Controller")
            detect = true;
        else
            detect = false;
    }
    // Testing
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Camera&Controller")
            detect = false;
        else
            detect = true;

    }
}
