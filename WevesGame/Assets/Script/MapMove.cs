using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour {

	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		// 移動
		Move ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Move() {
		Vector3 pos = transform.position;

		if (pos.z == 0) {
			iTween.MoveBy (gameObject, iTween.Hash (
				"z", -100,
				"easeType", iTween.EaseType.linear,
				"time", speed,
				"oncomplete", "Moved",
				"oncompletetarget", gameObject
			));
		}
		if (pos.z == 100) {
			iTween.MoveBy(gameObject,iTween.Hash(
				"z",-100,
				"easeType",iTween.EaseType.linear,
				"time",speed,
				"oncomplete","Move",
				"oncompletetarget",gameObject
			));
		}
	}

	void Moved() {
		transform.position = new Vector3 (transform.position.x, transform.position.y, 100);
		Move ();
	}
}
