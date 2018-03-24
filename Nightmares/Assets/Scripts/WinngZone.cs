using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinngZone : MonoBehaviour {

	bool playerInWin = false;
	GameObject player;
	Animator anim;



	void Awake ()
	{

		player = GameObject.FindGameObjectWithTag ("Player");
	}



	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player) {
			playerInWin = true;

			
			print("YOU WIN");
		}
	}
}
