using Fighter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuPokemon
{
    internal class Team
    {
        public Fighters[] _fighters = new Fighters[3];
        Fighters _chassaing = new("CHASSAING", 14 ,4);
        Fighters _cyrian = new("CYRIAN", 12, 5);
        Fighters _karma = new("KARMA", 22, 2);

        public Team()
        {
            _fighters[0] = _chassaing;
            string[] atkChassaing = { "3.6 NoScope","Cou2Cross","America F*ck YEAH","Headshot" };
            _fighters[0].Attack = atkChassaing;
            _fighters[1] = _cyrian;
            string[] atkCyrian = { "Stielhandgranate 24", "feux d’artifice", "cocktail molotov", "Grenade de glace" };
            _fighters[1].Attack = atkCyrian;
            _fighters[2] = _karma;
            string[] atkKarma = { "uppercut", "coup de queue", "Mawashi-geri", "roulade" };
            _fighters[2].Attack = atkKarma;
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