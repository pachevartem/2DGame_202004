using UnityEngine;

namespace OOP
{
    public class Humanoid: MonoBehaviour
    {
        
        
        [Header("Введите характеристики персонжа")]
        public string Name;
        [Tooltip("Укажи возраст")]
        public int Age;

        [Header("Выбери свою расу")]
        public TypeRaсe Raсe;
        protected void SayHello()
        {
            Debug.Log("My name is - "+Name);
            
        }

        public virtual void WinBehaviuor()
        {
            Debug.Log("Вызывается анимация победы как у человека");
        }

        protected void SayAge()
        {
            Debug.Log("My Age is - "+Age);
        }
    }
}