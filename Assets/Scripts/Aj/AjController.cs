using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjController : MonoBehaviour
{
    private Animator _animator;
    public float SpeedWalk = 1;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var h = Input.GetAxis("Horizontal");
        _animator.SetFloat("speed", h*SpeedWalk);
        if (h > 0)
        {
            transform.Translate(Vector3.forward * SpeedWalk*Time.deltaTime);
        }
    }
}