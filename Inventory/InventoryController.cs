using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {

    // Initialize to avoid null reference
    private bool isOn = false;

    public GameObject inventoryCanvas;

	// Update is called once per frame
	void Update () {

        // Toggle ON/OFF
        if (Input.GetKeyDown(KeyCode.I))
            isOn = !isOn;
		
        // Check ON/OFF
        if (isOn) ? inventoryCanvas.SetActive(true) :  inventoryCanvas.SetActive(false);	
    }
}
