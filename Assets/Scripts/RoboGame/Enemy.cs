using UnityEngine;

namespace RoboGame
{
    public class Enemy: MonoBehaviour
    {
        public delegate void EnemyDelegate();
        public static EnemyDelegate Kill;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Kill(); // псевдо Event
            }
        }
    }
}