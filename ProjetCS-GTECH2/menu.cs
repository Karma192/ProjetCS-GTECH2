using Save;

namespace MenuPokemon
{
    internal class Menu
    {
        bool _active;
        int _index;
        string _inventory = "INVENTORY";
        string _save = "SAVE";
        string _team = "TEAM";
        string _menu = "MENU";


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
                DrawMenu();
                switch (_index)
                {
                    case (int)index.INVENTORY:
                        Console.SetCursorPosition(60 -(_inventory.ToCharArray().Length /2), 2);
                        Console.WriteLine(_inventory);
                        inventory.ShowInventory();
                        break;
                    case (int)index.TEAM:
                        Console.WriteLine(_team);
                        break;
                    case (int)index.SAVE:
                        Console.WriteLine(_save);
                        break;
                    case (int)index.MENU:
                        Console.WriteLine(_menu);
                        break;
                    default:
                        break;
                }
            }
        }

        private void DrawMenu()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.WriteLine("O", j, i);
                }
            }
            Console.ForegroundColor= ConsoleColor.Black;
        }
    }
}