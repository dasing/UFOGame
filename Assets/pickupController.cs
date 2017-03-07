using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupController : MonoBehaviour {

	public float RotateSpeed = 45;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate ( new Vector3( 0, 0, RotateSpeed*Time.deltaTime ) );
	}
}
