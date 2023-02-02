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

        public void DetectFight(Player player, List<Ennemi> ennemi, MapManager mapManager, SpawnerEnnemy sp)
        {
            if (!_onFight)
            {
                foreach (var e in ennemi)
                {
                    if (player.GetXPos() == e.GetXPos() && player.GetYPos() == e.GetYPos())
                    {
                        mapManager.ChangeMap(3, sp);
                        _onFight = true;
                    }
                }
            }
        }
    }
}