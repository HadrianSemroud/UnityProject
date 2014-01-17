using UnityEngine;
using System.Collections;



public class Bullet : MonoBehaviour {
	
	public GameObject bullet;
	public float speedBullet;
		
	Vector2 position;
	
	// Use this for initialization
	void Start () 
	{	

	}

	void move ()
	{	
		/*if (position.x > 1) Destroy(gameObject);
		if (position.x < 0) Destroy(gameObject);*/
		
		//fait avancer la bullet
		bullet.transform.Translate(Vector3.forward*speedBullet);
	}
	
	// Update is called once per frame
	void Update () 
	{
		move ();
		destruct();
	}

	void destruct()
	{
		if ((this.transform.position.x > 25) || (this.transform.position.x < -25)) Destroy(gameObject);
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "ennemy") Destroy(col.gameObject);
	}
}
