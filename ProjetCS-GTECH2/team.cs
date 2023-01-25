using Fighter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPokemon
{
    internal class Team
    {
        Fighters[] _fighters;

        public void ShowTeam()
        {
            if (_fighters != null)
            {
                foreach (var fighter in _fighters)
                {
                    Console.WriteLine(fighter.ShowFighter());                    
                }
            }
        }

        public void AddToTeam(Fighters fighter)
        {
            int index = _fighters.Length;
            _fighters.SetValue(fighter, index);
        }
    }
}