using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlighLightOnOff : MonoBehaviour {

	public Light light;
	UnityEngine.AI.NavMeshAgent nav;
	GameObject[] allEnemies;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//nav = GameObject ("NavMeshAgent");
		//nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		if (Input.GetKeyDown ("space")) {
			
			light.enabled = !light.enabled;
			print ("space pressed");
			//make the mosters stop moving//////
			GameObject[] allEnemies = GameObject.FindGameObjectsWithTag ("Enemy");
			foreach (GameObject enemy in allEnemies)
				enemy.GetComponent<UnityEngine.AI.NavMeshAgent> ().speed = 0f;
			//nav.enabled = false;

			Invoke ("TurnBackOnSpeed", 2f); 
		}
	}

	void TurnBackOnSpeed()
	{
		GameObject[] allEnemies = GameObject.FindGameObjectsWithTag ("Enemy");
		foreach (GameObject enemy in allEnemies)
			enemy.GetComponent<UnityEngine.AI.NavMeshAgent> ().speed = enemy.GetComponent<EnemyMovement> ().speed;
		light.enabled = !light.enabled;
		}
}
