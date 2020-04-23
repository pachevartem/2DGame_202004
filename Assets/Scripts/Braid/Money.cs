using System;
using UnityEngine;

namespace BraidGame
{
    public class Money: MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                FindObjectOfType<GameController>().ScoreBank.AddMoney(1);
                gameObject.SetActive(false);
            }
        }
    }
}