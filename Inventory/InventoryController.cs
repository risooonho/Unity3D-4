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
	// Update
        // Check ON/OFF
        if (isOn)
            inventoryCanvas.SetActive(true);
        else
            inventoryCanvas.SetActive(false);
		
    }
}
