using UnityEngine;
using System.Collections;

public class EnemyBehavior2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider other)
	{
		if (other.tag == "bullet")
		{
			Destroy(gameObject);
			Debug.Log("ok");
		}
	}
}
