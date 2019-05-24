using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostController : MonoBehaviour
{
    private GameObject player;
    private GameObject frostZone;
    private FrostEffect playerScript;
    private const float coef = 0.1f;
    private bool detect = true;

    // TODO: Collision detection implementation

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("FPSCamera");
        this.playerScript = player.GetComponent<FrostEffect>();
        this.frostZone = GameObject.Find("FrostZone");
        this.playerScript.FrostAmount = 0f;
    }

    private void Update()
    {
        if (detect)
        {
            this.playerScript.FrostAmount += coef * Time.deltaTime;
        }
    }
}


