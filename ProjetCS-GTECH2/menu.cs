using Save;

namespace MenuPokemon
{
    internal class Menu
    {
        const int _height = 29;
        const int _width = 30;
        bool _active;
        int _index;
        string _inventory = "INVENTORY";
        string _save = "SAVE";
        string _team = "TEAM";
        string _menu = "MENU";


        Inventory inventory = new();

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
                _index = 0;
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
                DrawMenuBackground();
                switch (_index)
                {
                    case (int)index.INVENTORY:
                        WriteTitleMenu(_inventory);
                        inventory.ShowInventory();
                        break;
                    case (int)index.TEAM:
                        WriteTitleMenu(_team);
                        break;
                    case (int)index.SAVE:
                        WriteTitleMenu(_save);
                        break;
                    case (int)index.MENU:
                        WriteTitleMenu(_menu);
                        for (int i = 0; i < 4; i++)
                        {
                            Console.SetCursorPosition(2, (5 +(i * 2)));
                            switch (i)
                            {
                                case (int)index.MENU:
                                    Console.WriteLine("M : Close the menu");
                                    break;
                                case (int)index.INVENTORY:
                                    Console.WriteLine("I : " + _inventory);
                                    break;
                                case (int)index.TEAM:
                                    Console.WriteLine("T : " + _team);
                                    break;
                                case (int)index.SAVE:
                                    Console.WriteLine("S : " + _save);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void DrawMenuBackground()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Console.SetCursorPosition((int)j, (int)i);
                    Console.WriteLine(" ");
                }
            }
        }

        private void WriteTitleMenu(string title)
        {
            Console.SetCursorPosition((_width / 2) - (title.ToCharArray().Length / 2), 1);
            Console.WriteLine(title);
        }
    }
}