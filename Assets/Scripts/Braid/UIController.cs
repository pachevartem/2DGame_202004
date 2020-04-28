using System;
using UnityEngine;
using UnityEngine.UI;

namespace BraidGame
{
    public class UIController: MonoBehaviour
    {
        public Slider HpBar;
        public Text CountCoins;

        private int HP = 100; //TODO: не должно быть тут.

        private void Awake()
        {
            Enemy.OnDamage += Damage;
            Bank.OnChangeBank += ChangeText;
        }

        private void OnDestroy()
        {
            Enemy.OnDamage -= Damage;
            Bank.OnChangeBank -= ChangeText;

        }

        void Damage()
        {
            HP -= 20;
            HpBar.value = ((float)HP /(float)100);  //TODO: Обычно тут другая математика :)))
        }


         void ChangeText(int count)
         {
             CountCoins.text = count.ToString();
         }
    }
}