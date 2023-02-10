using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Character
    {
        // классы содержат данные и методы

        // данные могут быть записаны по-разному
        // например, существуют поля, они как переменные

        // также есть поведение класса
        // поведение класса задаётся методом (или функцией)
        // на самом деле функций в C# нет
        // (функция - метод вне класса)
        private int health = 100;

        public int Health // поле
        {
            get // свойство поля
            {
                return health;
            }
            private set 
            {
                health = value; // невидимый аргумент, значение которого передаётся
            }
        }

        public void Hit(int damage) // void означает, что метод ничего не возвращает
        {
            if (damage > health)
            damage = health;

            Health -= damage;
        }
    // public, internal, protected
    // private по умолчанию
    // класс по умолчанию internal
    }
}
