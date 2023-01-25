using MenuPokemon;
using pokehunter;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Program
{
    internal class Program
    {

        static void Main()
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo input = new();
            Menu menu = new();
            MapInit map = new();
            Player player = new();
            Ennemi e = new();
            Fight f = new();
            char move;
            bool canMove = false;

            while (Open(input)) {
                input = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                map.InitTab();
                menu.MenuUpdate(input); 
                e.DrawEnnemi();
                move = player.Getinput(input);
                canMove = TestMovement(move, map, player);
                if (canMove) 
                {
                    player.Mouvement(move);
                }
                player.DrawPlayer();
                f.StartFight();

                
            }
        }

        private static bool TestMovement(char move, MapInit map, Player player)
        {
            switch (move)
            {
                case 'U':
                    if (map.tab[player.GetXPos(),player.GetYPos() - 1] == 1)
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
