using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
	public float speed = 3f;

	public WinngZone inZone;
	//public bool playerInWin;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
		if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0 ) //&& flashlight is on)
        {
            nav.SetDestination (player.position);
        }
        else
        {
            nav.enabled = false;
        }
		//if (inZone.playerInWin == true) {
		//	nav.enabled = false;
		//}
    }
}
