using System;
using UnityEngine;

namespace RoboGame
{
    public  class Statistic: MonoBehaviour
    {
        private void Awake()
        {
            Enemy.Kill += AddCount;
        }

        private  int CountDeath = 0;

        public void AddCount()
        {
            CountDeath++;
            Debug.Log(CountDeath);
        }

        public int GetNumberDeath()
        {
            return CountDeath;
        }

    }
}