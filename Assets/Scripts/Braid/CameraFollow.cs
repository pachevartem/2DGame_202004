using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace BraidGame
{
    public class CameraFollow: MonoBehaviour
    {
        //ссылка на камеру
        private Transform _cam;

        public Transform Target;

        public float FollowSpeed = 1;


        private void Awake()
        {
            _cam = Camera.main.transform;
        }
        
        private void Update()
        {
            Follow();
        }


        void Follow() //TODO: Придумать нормальное название методу
        {

            var _temp = new Vector3(
                Mathf.Lerp(_cam.position.x, Target.position.x, Time.deltaTime * FollowSpeed),
                Mathf.Lerp(_cam.position.y, Target.position.y, Time.deltaTime * FollowSpeed),
                _cam.position.z);

            _cam.position = _temp;

        }
    }
}