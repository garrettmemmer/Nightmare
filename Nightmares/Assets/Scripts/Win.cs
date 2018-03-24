//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class Win : MonoBehaviour {
//
//	// Use this for initialization
//	bool playerInWin = false;
//	GameObject player;
//	Animator anim;
//
//
//	void OnTriggerEnter (Collider other)
//	{
//		if (other.gameObject == player) {
//			playerInWin = true;
//
//
//			print("YOU WIN");
//		}
//	}
//
//
//	void Awake ()
//	{
//		player = GameObject.FindGameObjectWithTag ("Player");
//		anim = GetComponent<Animator>();
//
//	}
//	// Update is called once per frame
//	void Update () {
//		if (playerInWin == true) {
//			anim.SetTrigger ("YouWin");
//			//play win screen
//			//			print("YOU WIN");
//		}
//	}
//}

