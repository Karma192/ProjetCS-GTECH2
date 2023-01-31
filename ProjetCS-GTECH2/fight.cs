using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pokehunter
{
    internal class Fight
    {
        bool _onFight;

        public Fight()
        {

        }

        public bool OnFight { get => _onFight; }

        public void QuitFight(MapManager mapManager, Player player)
        {
            _onFight = false;
            Console.WriteLine(player.GetXPos() + " " + player.GetYPos());
            player.SetPlayerPos(player.GetXPos() - 1, player.GetYPos() - 1);
            Console.WriteLine(player.GetXPos() + " " + player.GetYPos());
            mapManager.QuitFight();
        }

        public void DetectFight(Player player, Ennemi ennemi, MapManager mapManager)
        {
            if (!_onFight)
            {
                if (player.GetXPos() == ennemi.GetXPos() && player.GetYPos() == ennemi.GetYPos())
                {
                    mapManager.ChangeMap(3);
                    _onFight = true;
                }
            }
        }
    }
}