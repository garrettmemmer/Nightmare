using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinngZone : MonoBehaviour {

	bool playerInWin = false;
	GameObject player;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player) {
			playerInWin = true;
			//play win screen
			print("YOU WIN");
		}
	}
}
