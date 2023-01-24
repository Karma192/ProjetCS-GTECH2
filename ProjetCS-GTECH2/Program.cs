using MenuPokemon;
using pokehunter;
using System;
using System.Windows.Input;

namespace Program
{
    internal class Program
    {
        ConsoleKeyInfo _input = new();

        private static void Main()
        {
            Menu menu= new();
            MapInit map = new();
            Player p = new Player();

            while (Open(Console.ReadKey())) {
                Console.Clear();
                map.InitTab();
                menu.MenuUpdate(Console.ReadKey());
                p.DrawPlayer();
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
                } else
                {
                    return true;
                }
            } else
            {
                return true;
            }
        }
    }
}
