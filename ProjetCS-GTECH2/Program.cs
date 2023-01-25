using MenuPokemon;
using pokehunter;
using System;
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
            Ennemi ennemi = new();
            Fight fight = new();


            while (Open(input))
            {
                input = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                map.InitTab();
                menu.MenuUpdate(input);
                ennemi.DrawEnnemi();
                player.Movement(input);
                player.DrawPlayer();
                fight.StartFight();

            }
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
