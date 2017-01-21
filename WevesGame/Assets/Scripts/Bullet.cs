using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour {
    public GameObject bullet;
    [SerializeField] GameObject Cannon;
    private Transform muzzle;
    public float speed = 1000;

    float x;
    float y;
    float z;

    void Start()
    {

    }

    // Use this for initialization
    void Awake () {

        Vector3 vecMouse = Input.mousePosition;
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(vecMouse);

        Debug.Log(screenPos);

        screenPos.x = x;
        screenPos.y = y;
        screenPos.z = z;

        gameObject.GetComponent<Transform>().DOMove(new Vector3 (x,y,z), 2f);
        //gameObject.GetComponent<Transform>().DOMove(new Vector3 (0,0,0), 2f);

        Invoke("DestroyBullet", 1.8f);

    }

    // Update is called once per frame
    void Update () {
		
	}

    void DestroyBullet() {
        Destroy(gameObject);

    }
}
