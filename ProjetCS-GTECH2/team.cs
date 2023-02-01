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
        Fighters _chassaing = new("CHASSAING", 14, 4);
        Fighters _cyrian = new("CYRIAN", 12, 5);
        Fighters _karma = new("KARMA", 22, 2);

        public Team()
        {
            Fighters[0] = _chassaing;
            string[] atkChassaing = { "3.6 NoScope", "Cou2Cross", "America F*ck YEAH", "Headshot" };
            Fighters[0].Attack = atkChassaing;
            Fighters[1] = _cyrian;
            string[] atkCyrian = { "Stielhandgranate 24", "feux d’artifice", "cocktail molotov", "Grenade de glace" };
            Fighters[1].Attack = atkCyrian;
            Fighters[2] = _karma;
            string[] atkKarma = { "uppercut", "coup de queue", "Mawashi-geri", "roulade" };
            Fighters[2].Attack = atkKarma;
        }

        public Fighters[] Fighters { get => _fighters; }

        public Fighters[] GetTeam() 
        {
            return Fighters;
        }


        public void ShowTeam()
        {
            if (Fighters != null)
            {
                int posY = 2;
                foreach (var fighter in Fighters)
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