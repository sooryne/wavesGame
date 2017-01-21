using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WaveColider : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        transform.DOScale(new Vector3(40f, 4f, 40f), 2f).SetEase(Ease.InOutQuad);
        Invoke("DestroyWaveColider", 3f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void DestroyWaveColider()
    {
        Destroy(gameObject);

    }
}
