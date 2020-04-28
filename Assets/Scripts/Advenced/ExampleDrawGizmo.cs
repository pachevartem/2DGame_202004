using System;
using UnityEditor;
using UnityEngine;

namespace Advenced
{
    public class ExampleDrawGizmo: MonoBehaviour
    {
        [Range(1,3)]
        public float Radius;
        public GameObject objec2;
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position,Vector3.one*1.2f);
            Gizmos.DrawWireSphere(transform.position, Radius);
            Gizmos.DrawLine(transform.position, objec2.transform.position);
            Gizmos.DrawFrustum(transform.position, 50,4,0.1f,1);
            Gizmos.DrawIcon(transform.position, "logo.png", true);
        }
    }
}