using Save;

namespace MenuPokemon
{
    internal class Menu
    {
        bool _active;
        int _index;
        inventory inventory = new();

        enum index
        {
            MENU = 0,
            INVENTORY = 1,
            TEAM = 2,
            SAVE = 3,
        }

        public void MenuUpdate(ConsoleKeyInfo input)
        {
            ActiveMenu(input);
            ActiveIndex(input);
            ShowMenu();
        }

        private void ActiveMenu(ConsoleKeyInfo input)
        {
            if (input.Key == ConsoleKey.M)
            {
                _active = !_active;
            }
        }

        private void ActiveIndex(ConsoleKeyInfo input)
        {
            if (_active)
            {
                switch (input.Key)
                {
                    case ConsoleKey.I:
                        _index = 1;
                        break;
                    case ConsoleKey.T:
                        _index = 2;
                        break;
                    case ConsoleKey.S:
                        _index = 3;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ShowMenu()
        {
            if (_active)
            {
                switch (_index)
                {
                    case (int)index.INVENTORY:
                        Console.WriteLine("INVENTORY");
                        inventory.ShowInventory();
                        break;
                    case (int)index.TEAM:
                        Console.WriteLine("SQUAD");
                        break;
                    case (int)index.SAVE:
                        Console.WriteLine("SAVE");
                        break;
                    case (int)index.MENU:
                        Console.WriteLine("MENU");
                        break;
                    default:
                        Console.WriteLine("An error occured in the menu...");
                        break;
                }
            }
        }
    }
}