using MenuPokemon;
using pokehunter;
using GameSave;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ProjetCS_GTECH2;

namespace Program
{
    internal class Program
    {

        static void Main()
        {
            Save save = new();
            Console.CursorVisible = false;
            ConsoleKeyInfo input = new();
            MapManager mapManager = new();
            Menu menu = new();
            Player player = new();
            Ennemi ennemi = new("Pikachu",60,20, 40, 5);
            Fight fight = new();
            sceneMenu menuScene = new();
            char move;
            bool canMove = false;

            menuScene.SceneUpdate(input, save, ref player, mapManager);
            

            while (Open(input))
            {
                input = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                fight.DetectFight(player, ennemi, mapManager);
                mapManager.DrawMap();
                menu.MenuUpdate(input, ennemi, save, player, mapManager, fight);
                ennemi.DrawEnnemi();
                move = player.Getinput(input);
                canMove = TestMovement(move, mapManager.GetMap(), player);

                if (canMove && !menu.GetActiveMenu && !menu.GetFightMenu && !fight.OnFight)
                {
                    player.Mouvement(move);
                }

                player.DrawPlayer();
              
                if (!fight.OnFight)
                {
                    player._player = "P";
                }
                else
                {
                    player._player = " ";
                }

            }
        }

        private static bool TestMovement(char move, Map map, Player player)
        {
            switch (move)
            {
                case 'U':
                    if (map.tab[player.GetXPos(), player.GetYPos() - 1] == 1)
                    {
                        return false;
                    }
                    else
                    {

                        return true;
                    }
                case 'D':
                    if (map.tab[player.GetXPos(), player.GetYPos() + 1] == 1)
                    {
                        return false;
                    }
                    else
                    {

                        return true;
                    }
                case 'L':
                    if (map.tab[player.GetXPos() - 1, player.GetYPos()] == 1)
                    {
                        return false;
                    }
                    else
                    {

                        return true;
                    }
                case 'R':
                    if (map.tab[player.GetXPos() + 1, player.GetYPos()] == 1)
                    {
                        return false;
                    }
                    else
                    {

                        return true;
                    }
                default:
                    break;
            }
            return false;
        }

        private static bool Open(ConsoleKeyInfo input)
        {
            if (input.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Are you sure you want to quit ? Y/N");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
