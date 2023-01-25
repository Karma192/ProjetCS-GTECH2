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

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public Fighters(string name)
        {
            _name = name;
        }

        public string ShowFighter()
        {
            string show = _name + " : Actual HP -> " + _health;
            return show;
        }
    }
}