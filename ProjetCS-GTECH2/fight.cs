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
            
            int playerXPos = player.GetXPos();
            int playerYPos = player.GetYPos();

            int ennemiXPos = ennemi.GetXPos();
            int ennemiYPos = ennemi.GetYPos();

            if(playerXPos == ennemiXPos && playerYPos == ennemiYPos)
            {
                Console.Clear();
                return true;
                

            }
            else
            {
                return false;
            }
            
        }

       
    }
}