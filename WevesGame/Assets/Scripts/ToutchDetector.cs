using UnityEngine;
using System.Collections;

public class ToutchDetector : MonoBehaviour
{
    //検知用レイ
    private RaycastHit Hit;

    void Update()
    {

        if (Physics.Raycast(transform.position, Vector3.down, out Hit))
        {

            Debug.Log(Hit.point);//デバッグログにヒットした場所を出す

        }

    }

}