using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlighLightOnOff : MonoBehaviour {

	public Light light;
	UnityEngine.AI.NavMeshAgent nav;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//nav = GameObject ("NavMeshAgent");
		//nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		if (Input.GetMouseButtonDown (1)) {
			light.enabled = !light.enabled;
			print ("left click pressed");
			//make the mosters stop moving//////
			//enemy.nagivgation.off   ?????

			//nav.enabled = false;
		}
	}
}
