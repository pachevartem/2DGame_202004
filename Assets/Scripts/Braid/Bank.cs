using System;
using UnityEngine;

namespace BraidGame
{
    public class Bank
    {
        public static Action<int> OnChangeBank = i => { };

        public Bank(int countMoney)
        {
            _countMoney = countMoney;
            OnChangeBank(_countMoney);
        }

        private int _countMoney;

        public void AddMoney(int m)
        {
            _countMoney += m;
            OnChangeBank(_countMoney);
        }

        public int GetMoney()
        {
            return _countMoney;
        }
    }
}