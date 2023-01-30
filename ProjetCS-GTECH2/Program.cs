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
            Console.CursorVisible = false;
            ConsoleKeyInfo input = new();
            MapManager mapManager = new();
            Menu menu = new();
            Player player = new();
            Ennemi ennemi = new();
            Fight fight = new();
            sceneMenu menuScene = new();
            Save save = new();
            char move;
            bool canMove = false;
            bool onFight = false;

            menuScene.SceneUpdate(input);

            while (Open(input))
            {
                input = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                if (!menu.ActiveMenu)
                {
                    if (onFight == false)
                    {
                        mapManager.DrawMap();
                    }
                    else
                    {
                        mapManager.ChangeMap(3);
                        mapManager.DrawMap();
                    }
                }
                menu.MenuUpdate(input);
                ennemi.DrawEnnemi();
                move = player.Getinput(input);
                canMove = TestMovement(move, mapManager.GetMap(), player);
                if (canMove && !menu.ActiveMenu && !menu.FightMenu && !onFight)
                {
                    player.Mouvement(move);
                }
                player.DrawPlayer(10, 50);
                onFight = fight.StartFight(player, ennemi);
                if (onFight == false)
                {
                    player._player = "P";
                }
                else
                {
                    player._player = " ";
                    menu.FightMenu = true;
                }

                if (input.Key == ConsoleKey.L)
                {
                    save.DoSave();
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
