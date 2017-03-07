using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOComponent : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D myRigidBody2D;
	void Start () {
		myRigidBody2D = this.GetComponent<Rigidbody2D> ();
	}

	public float forceValue = 10;
	
	// Update is called once per frame
	void Update () {
		Vector2 force2D = Vector2.zero;
		if (Input.GetKey (KeyCode.W)) {
			//this.transform.position += new Vector3 ( 0, speed*Time.deltaTime, 0 );
			force2D.y += forceValue;
//			myRigidBody2D.AddForce(new Vector2 ( 0, forceValue) );
		}

		if (Input.GetKey (KeyCode.S)) {
			//this.transform.position += new Vector3 ( 0, -speed*Time.deltaTime, 0 );
//			myRigidBody2D.AddForce(new Vector2 ( 0, -forceValue) );
			force2D.y -= forceValue;
		}

		if (Input.GetKey (KeyCode.A)) {
			//this.transform.position += new Vector3 ( -speed*Time.deltaTime, 0, 0 );
//			myRigidBody2D.AddForce(new Vector2 ( -forceValue, 0) );
			force2D.x -= forceValue;
		}

		if (Input.GetKey (KeyCode.D)) {
			//this.transform.position += new Vector3 ( speed * Time.deltaTime, 0, 0);
//			myRigidBody2D.AddForce(new Vector2 ( forceValue, 0) );
			force2D.x += forceValue;
		}

		myRigidBody2D.AddForce (force2D);
	}

	void OnTriggerEnter2D( Collider2D other ){
		other.gameObject.SetActive (false);
	}
}
