using Fighter;
using GameSave;

namespace MenuPokemon
{
    internal class Menu
    {
        const int _height = 29;
        const int _width = 30;
        const int _heightFight = 8;
        const int _widthFight = 118;

        public bool _activeMenu;
        public bool _fightMenu = true;
        int _index;
        int _indexBis;
        string _inventory = "INVENTORY";
        string _save = "SAVE";
        string _team = "TEAM";
        int _indexActualFighter = 0;

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
            SWITCH = 2,
            ESCAPE = 3,
        }

        public void MenuUpdate(ConsoleKeyInfo input)
        {
            ActiveMenu(input);
            HandleKey(input);
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

        private void HandleKey(ConsoleKeyInfo input)
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
                            _indexBis = 0;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (_index != 3)
                        {
                            _index++;
                            _indexBis = 0;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (_indexBis != 0)
                        {
                            _indexBis--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (_indexBis != 3)
                        {
                            _indexBis++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        EnterAction();
                        break;
                    default:
                        break;
                }
            }
        }

        private void EnterAction()
        {
            if (_activeMenu)
            {
                switch (_index)
                {
                    case (int)indexMenu.INVENTORY:
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
                switch (_index)
                {
                    case (int)indexFight.ATTACK:
                        Console.WriteLine(team._fighters[_indexActualFighter].Attack[_indexBis]);
                        break;
                    case (int)indexFight.OBJECTS:
                        Console.WriteLine(inventory.GetObjects()[_indexBis]);
                        break;
                    case (int)indexFight.SWITCH:
                        Console.WriteLine(team._fighters[_indexBis].Name);
                        break;
                    case (int)indexFight.ESCAPE:
                        Console.WriteLine("You quit the fight...");
                        _fightMenu = false;
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
            Console.ForegroundColor = ConsoleColor.DarkRed;
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
                    Console.SetCursorPosition((int)j, (int)i + 19);
                    Console.WriteLine(" ");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case (int)indexFight.ATTACK:
                        if (_index == (int)indexFight.ATTACK)
                        {
                            ShowAttack();
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.SetCursorPosition(5, 23 + i);
                        Console.WriteLine("ATTACK");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case (int)indexFight.OBJECTS:
                        if (_index == (int)indexFight.OBJECTS)
                        {
                            ShowObjects();
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.SetCursorPosition(5, 23 + i);
                        Console.WriteLine("OBJECTS");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case (int)indexFight.SWITCH:
                        if (_index == (int)indexFight.SWITCH)
                        {
                            ShowSwitch();
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.SetCursorPosition(5, 23 + i);
                        Console.WriteLine("SWITCH");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case (int)indexFight.ESCAPE:
                        if (_index == (int)indexFight.ESCAPE)
                        {
                            Console.SetCursorPosition(17, 23);
                            Console.WriteLine("Are you sure ?");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.SetCursorPosition(5, 23 + i);
                        Console.WriteLine("ESCAPE");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        private void ShowAttack()
        {
            string[] atk = team._fighters[_indexActualFighter].Attack;
            int i = 23;
            foreach (string s in atk)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine(s);
                i++;
            }

            switch (_indexBis)
            {
                case 0:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                case 1:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                case 2:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                case 3:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                default:
                    break;
            }
        }

        private void ShowObjects()
        {
            string[] obj = inventory.GetObjects();
            int i = 23;
            foreach (string s in obj)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine(s);
                i++;
            }

            switch (_indexBis)
            {
                case 0:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                /*case 1:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                case 2:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                case 3:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;*/
                default:
                    break;
            }
        }

        private void ShowSwitch()
        {
            string[] mates = new string[3];
            mates[0] = team._fighters[0].Name;
            mates[1] = team._fighters[1].Name;
            mates[2] = team._fighters[2].Name;

            int i = 23;
            foreach (string s in mates)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine(s);
                i++;
            }

            switch (_indexBis)
            {
                case 0:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                case 1:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                case 2:
                    Console.SetCursorPosition(17, 23 + _indexBis);
                    Console.WriteLine("->");
                    break;
                default:
                    break;
            }
        }
    }
}