using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FAQ
{
    public class GameController: MonoBehaviour
    {
        private List<BoxCollider> _cubes = new List<BoxCollider>();

        private void Awake()
        {
            _cubes = FindObjectsOfType<BoxCollider>().ToList();
            Debug.Log(_cubes.Count);
            foreach (var boxCollider in _cubes)
            {
                boxCollider.transform.Translate(Vector3.up);
            }
        }
    }
}