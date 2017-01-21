﻿using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class BulletShot : MonoBehaviour
{
    public class Move : MonoBehaviour
    {
        private NavMeshAgent agent;

        private RaycastHit hit;
        private Ray ray;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 100f))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }

}