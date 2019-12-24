using UnityEngine;
using System.Collections;

// Attach script to compass hand UI and the player object to transform object inside the script.
public class Compass : MonoBehaviour {

	public Transform player;

	void Start(){

	}

	void Update(){
		transform.rotation = Quaternion.AngleAxis(player.eulerAngles.y, Vector3.forward);
	}
}
