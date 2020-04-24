using System;
using UnityEngine;
using UnityEngine.AI;

namespace AI
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(NavMeshAgent))]
    public class AgentAJ: MonoBehaviour
    {
        private NavMeshAgent _agent;
        private Animator _animator;
        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
            _animator = GetComponent<Animator>();
            AJGameController.OnClicks += MoveAJ;
        }

        private void Update()
        {
            var s = _agent.velocity.magnitude;
            _animator.SetFloat("speed", s);
        }

        void MoveAJ(Vector3 point)
        {
            _agent.SetDestination(point);
        }





    }
}