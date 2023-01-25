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

        public void StartFight()
        {
            Player player = new();
            Ennemi ennemi = new();
            
            int playerXPos = player.GetXPos();
            int playerYPos = player.GetYPos();

            int ennemiXPos = ennemi.GetXPos();
            int ennemiYPos = ennemi.GetYPos();

            if(playerXPos == ennemiXPos && playerYPos == ennemiYPos)
            {
                Console.Write("FIGHT");

            }



        }
    }
}