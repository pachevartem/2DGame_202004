using System;
using UnityEngine;

namespace FAQ
{
    public class CheckComponent: MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private BoxCollider _boxCollider;
        
        private void Awake()
        {
            if (GetComponent<BoxCollider>()== null)
            {
                Debug.LogError("На твоём объекте нет компонента "+ typeof(BoxCollider));
            }
        }
    }
}