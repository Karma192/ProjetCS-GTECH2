using Fighter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPokemon
{
    internal class Team
    {
        Fighters[] _fighters = new Fighters[3];
        Fighters _chassaing = new("CHASSAING", 14);
        Fighters _cyrian = new("CYRIAN", 12);
        Fighters _karma = new("KARMA", 22);

        public Team()
        {
            _fighters[0] = _chassaing;
            _fighters[1] = _cyrian;
            _fighters[2] = _karma;
        }

        public void ShowTeam()
        {
            if (_fighters != null)
            {
                int posY = 2;
                foreach (var fighter in _fighters)
                {
                    posY += 2;
                    if (fighter != null)
                    {
                        Console.SetCursorPosition(2, posY);
                        Console.WriteLine(fighter.ShowFighter());
                    }                    
                }
            }
        }
    }
}