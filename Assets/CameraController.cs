using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Transform cameraT;
	// Use this for initialization
	void Start () {
		cameraT = this.GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		cameraT.eulerAngles = Vector3.zero;
	}
}
