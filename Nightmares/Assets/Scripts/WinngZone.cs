using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinngZone : MonoBehaviour {

	public bool playerInWin = false;
	GameObject player;
	Animator anim;



	void Awake ()
	{

		player = GameObject.FindGameObjectWithTag ("Player");
		anim = GetComponent<Animator>();
	}



	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player) {
			playerInWin = true;

			
			print("YOU WIN");
		}
	}

	void Update () {
		if (playerInWin == true) {
			anim.SetTrigger ("Winner");
			//play win screen
					//	print("playerInWin == true");
		}
	}
}
