using System;
using UnityEngine;

namespace Advenced
{
    public class ExampleLineRenderer: MonoBehaviour
    {
        private LineRenderer lr;

        private void Awake()
        {
            lr = GetComponent<LineRenderer>();
            lr.positionCount = 2;
            lr.SetPosition(0,Vector3.zero);
        }
        
        private void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
          
                Debug.DrawLine(ray.origin, hit.point);
                if (Input.GetMouseButtonDown(0))
                {
                    AddPoint(hit.point);
                }
            }

            
        }
        
        void AddPoint(Vector3 point)
        {
            lr.SetPosition(1,point);
        }
    }
}