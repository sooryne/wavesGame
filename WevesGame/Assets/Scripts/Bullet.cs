using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour {
    private Vector3 Hitpoint;
    private GameObject target;

    float hitPointx;
    float hitPointy;
    float hitPointz;

    void Start()
    {
       
    }

    // Use this for initialization
    void Awake () {

        target = GameObject.Find("Target");
        Vector3 Hitpoint = target.GetComponent<Transform>().position;

        Debug.Log(Hitpoint);
        Debug.Log(Hitpoint.x);

        //取得したhitpointの座標に2秒間かけて弾を移動
        gameObject.GetComponent<Transform>().DOMove(new Vector3 (Hitpoint.x, Hitpoint.y, Hitpoint.z), 3f);


    }

    // Update is called once per frame
    void Update () {

        //水面に着弾した瞬間(=Yが０になった瞬間)の判定。
        if (this.transform.position.y > 0.5f && this.transform.position.y < 10.5f) {
            //着弾する瞬間に弾を削除する。
            Invoke("DestroyBullet", 0.1f);

        } 
		
	}

    //着弾した瞬間にBulletを削除し波紋を生成する。
    void DestroyBullet() {
        GameObject prefab = (GameObject)Resources.Load("Prefabs/Wave");
        Instantiate(prefab, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
