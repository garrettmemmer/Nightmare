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
		if (Input.GetMouseButtonDown (1)) {
			
			light.enabled = !light.enabled;
			print ("right click pressed");
			//make the mosters stop moving//////
			//if(enemy in collider){  
			GameObject[] allEnemies = GameObject.FindGameObjectsWithTag ("Enemy");

			foreach (GameObject enemy in allEnemies)
				enemy.GetComponent<UnityEngine.AI.NavMeshAgent> ().speed = 0f;
			//nav.enabled = false;

			Invoke ("TurnBackOnSpeed", 2f); //possibly need to move this after adding collider
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
