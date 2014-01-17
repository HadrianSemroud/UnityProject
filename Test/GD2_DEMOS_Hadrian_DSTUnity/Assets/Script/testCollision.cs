using UnityEngine;
using System.Collections;

public class testCollision : MonoBehaviour {
	
	public GameObject otherPlan;
	Vector3 direction;
	float magn;


void Update()
	{
	}


void OnTriggerEnter( Collider other)
	{
		Debug.Log("PRE "+other.rigidbody.velocity);
		magn = other.rigidbody.velocity.magnitude; 
		direction = otherPlan.transform.up;
		other.transform.position = otherPlan.transform.position + 2*direction;
		other.rigidbody.velocity = direction*magn;
		Debug.Log(other.rigidbody.velocity);
	}
}
