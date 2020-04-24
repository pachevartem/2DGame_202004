using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

namespace AI
{
    public class GameController : MonoBehaviour
    {
        List<NavMeshAgent> Agents;


        private void Awake()
        {
            Agents = new List<NavMeshAgent>();
            Agents = FindObjectsOfType<NavMeshAgent>().ToList();
        }

        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    foreach (var agent in Agents)
                    {
                        agent.SetDestination(hit.point);
                    }
                }

                Debug.DrawLine(ray.origin, hit.point);
            }
        }
    }
}