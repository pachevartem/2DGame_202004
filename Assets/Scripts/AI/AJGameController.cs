using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class AJGameController : MonoBehaviour
    {
        public static Action<Vector3> OnClicks = temp => { };
        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100) && Input.GetMouseButton(0))
            {
                Debug.DrawLine(ray.origin, hit.point);
                OnClicks(hit.point); // рассылка всем сообщения
            }
            
        }
    }
}