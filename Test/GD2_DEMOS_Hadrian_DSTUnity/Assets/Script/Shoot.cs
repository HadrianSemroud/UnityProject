using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public Camera mainCamera;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Shooting();
	}

	void Shooting ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(bullet, mainCamera.transform.position, mainCamera.transform.rotation);
			this.audio.Play();
		}
	}
}
