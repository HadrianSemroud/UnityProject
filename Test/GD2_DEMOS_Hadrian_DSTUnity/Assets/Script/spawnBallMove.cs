using UnityEngine;
using System.Collections;

public class spawnBallMove : MonoBehaviour {
	
	public GameObject spawnBall;
	public GameObject otherPlan;
	int i;
	
	// Update is called once per frame
	void Update () {
		i = Random.Range(0,10);

		if (i < 5) spawnBall.transform.Translate( Vector3.forward);
		else spawnBall.transform.Translate( Vector3.back);
	}
}
