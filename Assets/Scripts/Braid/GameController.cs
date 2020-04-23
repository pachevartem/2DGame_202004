using System;
using UnityEngine;

namespace BraidGame
{
    public class GameController: MonoBehaviour
    {
        public Bank ScoreBank = new Bank(0);

        private void Update()
        {
            Debug.Log(ScoreBank.GetMoney());
        }
    }
}