using UnityEngine;
using System.Collections;

public class controls : MonoBehaviour {

	//Variables du personnage
	public int vitessePerso = 10;
	public float vitesseJump = 10;
	Quaternion rotationZero;
	public GameObject controler;
	//bool jumping;
	public GameObject floor;
	public int health = 100;

	// Use this for initialization
	void Start () {
		if (rigidbody) rigidbody.freezeRotation = true;
		//jumping = false;
	}
	
	// Update is called once per frame
	void Update () {
		control();
		//Jump ();
	}

	void onGUI()
	{
		GUI.Box( new Rect(10, 30, 100, 20),"test " + health);
		Debug.Log("okokok");
	}


	/*void onTriggerEnter(Collision other)
	{
		if (other.transform.tag != "floor") 
		{
			jumping = false;
			Debug.Log("ok Had c'est  cool");
		}
	}
*/
	void control ()
		//basic ZQSD controls
	{
		if (Input.GetKey(KeyCode.Z))
		{
			controler.transform.Translate(Vector3.forward*vitessePerso*Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S))
		{
			controler.transform.Translate(Vector3.back*vitessePerso*Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.D))
		{
			controler.transform.Translate(Vector3.right*vitessePerso*Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.Q))
		{
			controler.transform.Translate(Vector3.left*vitessePerso*Time.deltaTime);
		}
	}

	/*void Jump() 
	{
		if ((Input.GetKey(KeyCode.Space)) && (jumping == false))
		{
			rigidbody.AddForce(0,vitesseJump,0,ForceMode.VelocityChange);
			jumping = true;
		}
	}*/

}