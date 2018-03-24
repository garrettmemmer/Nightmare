using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public bool playerInWinZone = false;
	GameObject player;

    Animator anim;
	float restartTimer;

	void Start(){
		GetComponentInChildren <WinngZone> ();
	}

    void Awake()
    {
        anim = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player");
    }


    void Update()
    {
		if (playerInWinZone == true) {
			anim.SetTrigger ("Winner");
					print("G-O playerInWin == true");
		}

        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;

			//if (restartTimer >= restartDelay) 
			//{
			//	Application.LoadLevel (Application.loadedLevel);
			//}
        }

    }


	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player) {
			playerInWinZone = true;
			anim.SetTrigger ("Winner");
			//anim.SetBool ("Win") = true;

			print("G-O player in win");
		}
	}
}
