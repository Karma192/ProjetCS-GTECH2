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
            Player p;
            p = new Player();
            Ennemi e;
            e = new Ennemi();

            int playerXPos = p.GetXPos();
            int playerYPos = p.GetYPos();

            int ennemiXPos = e.GetXPos();
            int ennemiYPos = e.GetYPos();

            if(playerXPos == ennemiXPos && playerYPos == ennemiYPos)
            {
                Console.Write("FIGHT");

            }



        }
    }
}