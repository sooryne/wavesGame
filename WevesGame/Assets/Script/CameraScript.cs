using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject playerObject;

	private Vector3 offset = Vector3.zero;

	// Use this for initialization
	void Start () {
		offset = transform.position - playerObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		//newPosition.x = playerObject.transform.position.x + offset.x;
		//newPosition.y = playerObject.transform.position.y + offset.y;
		//newPosition.z = playerObject.transform.position.z + offset.z;
		transform.position = newPosition;
	}
}
