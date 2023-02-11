using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Character
    {
        // поле и свойства поля
        // autoproperty с закрытым сеттером
        public int Health { get ; private set; } = 100; 

        /*
        public int GetHealth() // метод, вернее свойство, выраженное двумя методами
        {
            return Health;
        }
        private void SetHealth(int value)
        {
            Health = value;
        }
        */

        public void Hit(int damage) // void означает, что метод ничего не возвращает
        {
            if (damage > Health)
            damage = Health;

            // health -= damage;
            Health -= damage;

            // var health = GetHealth() - damage();
            // SetHealth(health);
        }

    // public, internal, protected
    // private по умолчанию
    // класс по умолчанию internal

        // свойства, в сравнении с методами, помогают сократить запись
    }
}
