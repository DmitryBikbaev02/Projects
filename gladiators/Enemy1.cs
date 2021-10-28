using System;
using System.Collections.Generic;
using System.Text;

namespace gladiators
{
    class Enemy1
    {
        public Enemy1()
        {


            int _health = 100;
            int _damage = 20;
            int _armor = 100;
        }

        public int Getdamage(int _damage, int _health, int _armor) //Метод, когда персонажа Enemy1 бьет враг// 
        {
            if (_armor <= 0)
            {
                _health = _health - _damage;
            }
            if (_armor > 0)
            {
                _armor = _armor - _damage;
            }

        }




    }
}
}
