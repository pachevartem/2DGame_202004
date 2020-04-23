using System;
using UnityEngine;

namespace BraidGame
{
    /// <summary>
    /// Данный клас описывает 2Д препядствия в нашей игре
    /// </summary>
    public class Enemy: MonoBehaviour
    {
        // public BraidController _player; // плохо что надо делать это руками
        BraidController _player;

         private void Awake()
         {
             // _player = GameObject.Find("Braid_Idel").GetComponent<BraidController>(); 
             _player = GameObject.FindObjectOfType<BraidController>();
         }

         private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
            _player.ResetPosition();
            }
            // other.SendMessage("ResetPosition"); //запрещено к использованию
            // other.GetComponent<BraidController>().ResetPosition(); // 3/10 не надо так
            
        }
    }
}