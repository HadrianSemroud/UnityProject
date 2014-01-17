using UnityEngine;
using System.Collections;

public class EnnemyBehavior : MonoBehaviour {

	public GameObject spawnZone;
	public GameObject ennemy;
	bool spawnPossible;
	GameObject[] nbEnnemies;
	public int nbEnnemy;

	// Use this for initialization
	void Start () {
		spawnPossible = true;
	}
	
	// Update is called once per frame
	void Update () {
		checkSpawnPossible();
		spawn();
	}

	void checkSpawnPossible()
	{
		nbEnnemies = GameObject.FindGameObjectsWithTag("ennemy");
		if (nbEnnemies.Length > nbEnnemy) spawnPossible = false;
		else spawnPossible = true;
	}

	void spawn()
	{
		if (spawnPossible ==  true)
		{
			Instantiate(ennemy, spawnZone.transform.position, spawnZone.transform.rotation);
		}
	} 
}
