using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyUniversalScript : MonoBehaviour
{
    public UnityEvent OnCollision;
    public UnityEvent MyMouseDown;
    public UnityEvent MyMouseExit;
    private void OnCollisionEnter(Collision other)
    {
        OnCollision.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnMouseDown()
    {
        MyMouseDown.Invoke();
    }

    private void OnMouseExit()
    {
        MyMouseExit.Invoke();
    }
}
