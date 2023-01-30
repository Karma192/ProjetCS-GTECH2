using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pokehunter
{
    public class Fight
    {
        public Fight()
        {

        }

        public bool StartFight(Player player, Ennemi ennemi)
        {

            if (player.GetXPos() == ennemi.GetXPos() && player.GetYPos() == ennemi.GetYPos())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}