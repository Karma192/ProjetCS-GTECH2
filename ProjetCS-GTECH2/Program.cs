using MenuPokemon;

namespace Program 
{
    internal class Program
    {
        private static void Main()
        {
            Menu menu= new();
            Console.WriteLine("Hello, World!");

            while (Open(Console.ReadKey())) {
                Console.Clear();
                menu.MenuUpdate(Console.ReadKey());
                
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
