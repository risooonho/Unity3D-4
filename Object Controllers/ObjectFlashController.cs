using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFlashController : MonoBehaviour
{
    public GameObject selectedObject;
    public int red;
    public int green;
    public int blue;
    public bool lookingAtObject = false;
    public bool flashingIn = true;
    public bool startedFlashing = false;

    // Update is called once per frame
    void Update()
    {
        if (lookingAtObject)
        {
            selectedObject.GetComponent<Renderer>().material.color = new Color32((byte)red, (byte)green, (byte)blue, 255);
        }    
    }

    private void OnMouseOver()
    {
        // Note: Place name of object in Find()
        selectedObject = GameObject.Find(CastObjectController.selectedObject);
        lookingAtObject = true;

        if (startedFlashing == false)
        {
            startedFlashing = true;
            StartCoroutine(FlashObject());
        }
    }

    private void OnMouseExit()
    {
        startedFlashing = false;
        lookingAtObject = false;
        StopCoroutine(FlashObject());

        // Set back to original default material
        selectedObject.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
    }

    IEnumerator FlashObject()
    {
        while (lookingAtObject)
        {
            yield return new WaitForSeconds(0.05f);
            if (flashingIn)
            {
                if (blue <= 30)
                {
                    flashingIn = false;
                }
                else
                {
                    blue -= 25;
                    red -= 25;

                }
            }
            if (flashingIn == false)
            {
                if (blue >= 250)
                {
                    flashingIn = true;
                }
                else
                {
                    red += 25;
                    blue += 25;
                }
            }
        }
    }
}
