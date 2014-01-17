using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public int maxHealth =100;
	public int curHealth = 100;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (curHealth == 1)
		{
			Destroy(gameObject);
			Debug.Log("You lose !");
		}
	}
	
	void OnGUI() {
		
		if (curHealth <1) // sinon division par zero et ca plante
		{
			curHealth =1;
		}
		
		GUI.Box(new Rect(10, 10, Screen.width / 2 /(maxHealth / curHealth), 20), curHealth + "/" + maxHealth);
		
	}
	

	void OnCollisionEnter(Collision collision) // La barre de vie descend quand le joueur touche un ennemi, un missile ennemi ou une comete
	{   
		if (collision.gameObject.tag == "ennemy")
		{ 
			curHealth-=10;
		}
		
		
		/* if (collision.gameObject.tag == "missileenemy")
  { 
   curHealth-=10;
   Destroy(collision.gameObject);
   
  } */
		
		
		
	}
	
}