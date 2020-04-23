using System;
using UnityEngine;

namespace RoboGame
{
    public class Robot: MonoBehaviour
    {
        private Vector3 _startPos;
        private void Awake()
        {
            _startPos = transform.position;
            Enemy.Kill += ResetPosition;
        }
        
        void ResetPosition()
        {
            transform.position = _startPos;
        }


        private void OnDisable()
        {
            Enemy.Kill -= ResetPosition;
        }
    }
}