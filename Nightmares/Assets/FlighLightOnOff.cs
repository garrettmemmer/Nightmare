using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlighLightOnOff : MonoBehaviour {

	public Light light;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			light.enabled = !light.enabled;
			print ("space pressed");
		}
	}
}
