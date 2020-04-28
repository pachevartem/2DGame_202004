using System;
using UnityEngine;

namespace BraidGame
{
    public class GameController: MonoBehaviour
    {
        public Bank ScoreBank;

        private int count_click = 0;

        private void Awake()
        {
            var _temp = PlayerPrefs.GetInt("scoreBank", 0);
            ScoreBank = new Bank(_temp);
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetInt("scoreBank",ScoreBank.GetMoney());
            PlayerPrefs.Save();
        }
    }
}