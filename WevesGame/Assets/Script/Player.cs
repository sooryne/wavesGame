using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Rigidbody rigidBody;
	BoxCollider playerCollider;

	private bool damageflag = false;	// ダメージをくらったかどうか
	private float endTime = 0.8f;		// 点滅終了時間
	private int flashCount = 0;			// 点滅カウント
	private int inputMuki = 0;			// 0:Up 1:Down 2:Left 3:Right

	public float speed = 2;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		playerCollider = GetComponent<BoxCollider> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		// move
		Move();

		// damage
		if (damageflag) {
			Damage();
		}
	}

	// 移動
	void Move () {
		// 前
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow) || 0 < Input.GetAxisRaw("Vertical")) {
			inputMuki = 0;
			rigidBody.velocity = new Vector3 (rigidBody.velocity.x, rigidBody.velocity.y, speed);
		}
		// 後ろ
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow) || Input.GetAxisRaw("Vertical") < 0) {
			inputMuki = 1;
			rigidBody.velocity = new Vector3 (rigidBody.velocity.x, rigidBody.velocity.y, -speed);
		}
		// 左
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow) || Input.GetAxisRaw("Horizontal") < 0) {
			inputMuki = 2;
			rigidBody.velocity = new Vector3 (-speed, rigidBody.velocity.y, rigidBody.velocity.z);
		}
		// 右
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow) || 0 < Input.GetAxisRaw("Horizontal")) {
			inputMuki = 3;
			rigidBody.velocity = new Vector3 (speed, rigidBody.velocity.y, rigidBody.velocity.z);
		}
	}

	// 当たり判定
	void OnCollisionEnter(Collision collision) {
		// 船と岩
		if (collision.gameObject.tag == "Rock") {
			// 船を点滅させて一時当たり判定をなくす
			if (damageflag == false) {
				flashCount = 0;
				damageflag = true;
				// 反対側にはじく
				if (inputMuki == 0) rigidBody.velocity = new Vector3 (rigidBody.velocity.x, rigidBody.velocity.y, -speed);
				if (inputMuki == 1) rigidBody.velocity = new Vector3 (rigidBody.velocity.x, rigidBody.velocity.y, speed);
				if (inputMuki == 2) rigidBody.velocity = new Vector3 (speed, rigidBody.velocity.y, rigidBody.velocity.z);
				if (inputMuki == 3) rigidBody.velocity = new Vector3 (-speed, rigidBody.velocity.y, rigidBody.velocity.z);
				// プレイヤーのColliderを消す
				playerCollider.enabled = false;
				// 岩のColliderを消す
				var rockCollider = GameObject.FindWithTag ("Rock").GetComponent<BoxCollider> ();
				rockCollider.enabled = false;
				// 点滅終了
				Invoke ("FlashEnd", endTime);
			}
		}
	}
	void OnTriggerEnter(Collider collision) {
	}

	// ダメージ
	void Damage() {
		flashCount++;
		Renderer ren = gameObject.GetComponent<Renderer> ();
		if (flashCount % 2 == 0) {
			ren.enabled = !ren.enabled;
		}
	}

	// 点滅終了
	void FlashEnd() {
		damageflag = false;
		gameObject.GetComponent<Renderer> ().enabled = true;
		// プレイヤーのColliderを戻す
		playerCollider.enabled = true;
		// 岩のColliderを戻す
		var rockCollider = GameObject.FindWithTag ("Rock").GetComponent<BoxCollider> ();
		rockCollider.enabled = true;
	}
}
