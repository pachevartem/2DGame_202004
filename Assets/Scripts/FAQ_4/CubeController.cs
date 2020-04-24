using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Coroutine _r;
    private int timer = 99;
    private void Start()
    {
        _r = StartCoroutine("StopWatch");
    }

    IEnumerator StopWatch()
    {
        for (; ; )
        {
            timer--;
            Debug.Log(timer);
            yield return new WaitForSeconds(1);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(_r);
        }
    }
}
