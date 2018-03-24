using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	bool playerInWin = false;
	GameObject player;

    Animator anim;
	float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player");
    }


    void Update()
    {
		if (playerInWin == true) {
			//anim.SetTrigger ("YouWin");
					print("playerInWin == true");
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
			playerInWin = true;
			anim.SetTrigger ("Winner");

			print("YOU WIN");
		}
	}
}
