using Save;

namespace MenuPokemon
{
    internal class Menu
    {
        const int _height = 29;
        const int _width = 30;
        const int _heightFight = 7;
        const int _widthFight = 118;

        public bool _activeMenu;
        public bool _fightMenu = true;
        int _index;
        string _inventory = "INVENTORY";
        string _save = "SAVE";
        string _team = "TEAM";


        Inventory inventory = new();
        Team team = new();

        enum indexMenu
        {
            INVENTORY = 0,
            TEAM = 1,
            SAVE = 2,
        }

        enum indexFight
        {
            ATTACK = 0,
            OBJECTS = 1,
            ESCAPE = 2,
        }

        public void MenuUpdate(ConsoleKeyInfo input)
        {
            ActiveMenu(input);
            ActiveIndex(input);
            ShowMenu();
        }

        private void ActiveMenu(ConsoleKeyInfo input)
        {
            if (input.Key == ConsoleKey.M && !_fightMenu)
            {
                _activeMenu = !_activeMenu;
                _index = 0;
            }
        }

        private void ActiveIndex(ConsoleKeyInfo input)
        {
            if (_activeMenu)
            {
                switch (input.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (_index != 0)
                        {
                            _index--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (_index != 2)
                        {
                            _index++;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (_fightMenu)
            {
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (_index != 0)
                        {
                            _index--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (_index != 2)
                        {
                            _index++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        break;
                    case ConsoleKey.RightArrow:
                        break;
                    default:
                        break;
                }
            }
        }

        private void ShowMenu()
        {
            if (_activeMenu && !_fightMenu)
            {
                DrawMenuBackground();
                WriteTitleMenu();
                switch (_index)
                {
                    case (int)indexMenu.INVENTORY:
                        inventory.ShowInventory();
                        break;
                    case (int)indexMenu.TEAM:
                        break;
                    case (int)indexMenu.SAVE:
                        break;
                    default:
                        break;
                }
            }

            if (_fightMenu)
            {
                DrawFightMenu();
            }
        }

        private void DrawMenuBackground()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Console.SetCursorPosition((int)j, (int)i);
                    Console.WriteLine(" ");
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Press M to exit menu...");
        }

        private void WriteTitleMenu()
        {
            switch (_index)
            {
                case (int)indexMenu.INVENTORY:
                    Console.SetCursorPosition(1, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(_inventory);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(2 + _inventory.ToCharArray().Length, 2);
                    Console.WriteLine(_team);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(3 + _inventory.ToCharArray().Length + _team.ToCharArray().Length, 2);
                    Console.WriteLine(_save);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case (int)indexMenu.TEAM:
                    Console.SetCursorPosition(1, 2);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(_inventory);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(2 + _inventory.ToCharArray().Length, 2);
                    Console.WriteLine(_team);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(3 + _inventory.ToCharArray().Length + _team.ToCharArray().Length, 2);
                    Console.WriteLine(_save);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case (int)indexMenu.SAVE:
                    Console.SetCursorPosition(1, 2);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(_inventory);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(2 + _inventory.ToCharArray().Length, 2);
                    Console.WriteLine(_team);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(3 + _inventory.ToCharArray().Length + _team.ToCharArray().Length, 2);
                    Console.WriteLine(_save);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    break;
            }
        }

        private void DrawFightMenu()
        {
            for (int i = 1; i < _heightFight + 1; i++)
            {
                for (int j = 1; j < _widthFight + 1; j++)
                {
                    Console.SetCursorPosition((int)j, (int)i + 20);
                    Console.WriteLine(" ");
                }
            }

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case (int)indexFight.ATTACK:
                        Console.SetCursorPosition(5, 23 +i); 
                        if (_index == (int)indexFight.ATTACK)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine("ATTACK");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case (int)indexFight.OBJECTS:
                        Console.SetCursorPosition(5, 23 + i);
                        if (_index == (int)indexFight.OBJECTS)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine("OBJECTS");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case (int)indexFight.ESCAPE:
                        Console.SetCursorPosition(5, 23 + i);
                        if (_index == (int)indexFight.ESCAPE)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine("ESCAPE");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}