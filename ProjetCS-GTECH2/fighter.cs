using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fighter
{
    public class Fighters
    {
        string _name;
        int _health = 100;
        string[] _attack = new string[4];
        int _defense;
        int _damage;

        public string Name
        {
            get => _name;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public string[] Attack
        {
            get => _attack;
            set => _attack = value;
        }

        public Fighters(string name, int defense, int damage)
        {
            _name = name;
            _defense = defense;
            _damage = damage;
        }

        public string ShowFighter()
        {
            string show = _name + " : Actual HP -> " + _health;
            return show;
        }
        public int Getdamage() 
        { 
            return _damage; 
        }
    }
}