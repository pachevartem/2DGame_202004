using System;
using UnityEngine;

namespace OOP
{
    public class Elf: Humanoid
    {
        public override void WinBehaviuor()
        {
            Debug.Log("Вызывается победа анимации Эльфа- сальтуха");
        }
    }
}