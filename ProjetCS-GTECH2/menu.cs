using Fighter;
using pokehunter;
using GameSave;

namespace MenuPokemon
{
    internal class Menu
    {
        const int _height = 29;
        const int _width = 30;
        const int _heightFight = 8;
        const int _widthFight = 118;

        bool _activeMenu;
        bool _fightMenu;
        bool _ennemyTurn;
        int _index;
        int _indexBis;
        int _indexBisLimMin = 0;
        int _indexBisLimMax;
        int _indexActualFighter = 0;
        string _inventory = "INVENTORY";
        string _save = "SAVE";
        string _team = "TEAM";

        Inventory inventory = new();
        Team team = new();
        Capacity capa = new();


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

        public bool GetActiveMenu { get => _activeMenu; }
        public bool GetFightMenu { get => _fightMenu; }

        public void MenuUpdate(ConsoleKeyInfo input, Ennemi ennemi, Save save, Player player, 
            MapManager mapManager, Fight fight)
        {
            if (!_activeMenu && !_fightMenu)
            {
                _index= 0;
                _indexBis = 0;
            }

            _fightMenu = fight.OnFight;
            ActiveMenu(input);
            HandleKey(input, ennemi, save, player, mapManager, fight);
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

        private void HandleKey(ConsoleKeyInfo input, Ennemi ennemi, Save save, Player player, MapManager mapManager, Fight fight)
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
                    case ConsoleKey.Enter:
                        EnterAction(ennemi, save, player, mapManager, fight);
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
                        if (_indexBis != _indexBisLimMin)
                        {
                            _indexBis--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (_indexBis != _indexBisLimMax)
                        {
                            _indexBis++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        EnterAction(ennemi, save, player, mapManager, fight);
                        break;
                    default:
                        break;
                }
            }
        }

        private void EnterAction(Ennemi ennemi, Save save, Player player, MapManager mapManager, Fight fight)
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
                        save.DoSave(player, team, mapManager, inventory);
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
                        if (_indexBis == 0)
                        {
                            if (_indexActualFighter == 0)
                            {
                                if (inventory._objects[0].Use(1) != false)
                                {
                                capa.NoScope(inventory, team.Fighters[_indexActualFighter], ennemi);
                                Console.WriteLine("Hp E : " + ennemi.GetHealth());
                                }
                            }
                            else if (_indexActualFighter == 1)
                            {
                                if (inventory._objects[1].Use(1) != false)
                                {
                                    capa.Stielhandgranate(inventory, team.Fighters[_indexActualFighter], ennemi);
                                    Console.WriteLine(ennemi.GetHealth());
                                }
                            }
                            else if(_indexActualFighter == 2)
                            {
                                capa.Uppercut(team.Fighters[_indexActualFighter], ennemi);
                                Console.WriteLine(ennemi.GetHealth());
                            }
                        }
                        else if (_indexBis == 1)
                        {
                            if (_indexActualFighter == 0)
                            {
                                capa.CoupDeCrosse(team.Fighters[_indexActualFighter], ennemi);
                                Console.WriteLine(ennemi.GetHealth());
                            }
                            else if (_indexActualFighter == 1)
                            {
                                if (inventory._objects[2].Use(1) != false)
                                {
                                    capa.Artifice(inventory, team.Fighters[_indexActualFighter]);
                                    Console.WriteLine(ennemi.GetHealth());
                                }
                            }
                            else if (_indexActualFighter == 2)
                            {
                                capa.CoupDeQueue(team.Fighters[_indexActualFighter], ennemi);
                                Console.WriteLine(ennemi.GetHealth());
                            }
                        }
                        else if (_indexBis == 2)
                        {
                            if (_indexActualFighter == 0)
                            {
                                if (inventory._objects[0].Use(1) != false)
                                {
                                    capa.AmericaFckYeah(team.Fighters[_indexActualFighter]);
                                    Console.WriteLine(ennemi.GetHealth());
                                }
                            }
                            else if (_indexActualFighter == 1)
                            {
                                if (inventory._objects[2].Use(1) != false)
                                {
                                    capa.Molotove(inventory, team.Fighters[_indexActualFighter], ennemi);
                                    Console.WriteLine(ennemi.GetHealth());
                                }
                            }
                            else if (_indexActualFighter == 2)
                            {
                                capa.MawashiGeri(team.Fighters[_indexActualFighter], ennemi);
                                Console.WriteLine(ennemi.GetHealth());
                            }
                        }
                        else if (_indexBis == 3)
                        {
                            if (_indexActualFighter == 0)
                            {
                                if (inventory._objects[0].Use(1) != false)
                                {
                                    capa.HeadShot(team.Fighters[_indexActualFighter], ennemi);
                                    Console.WriteLine(ennemi.GetHealth());
                                }
                            }
                            else if (_indexActualFighter == 1)
                            {
                                if (inventory._objects[4].Use(1) != false)
                                {
                                    capa.IceGrenade(inventory, team.Fighters[_indexActualFighter], ennemi);
                                    Console.WriteLine(ennemi.GetHealth());
                                }
                            }
                            else if (_indexActualFighter == 2)
                            {
                                capa.Roulade(team.Fighters[_indexActualFighter]);
                                Console.WriteLine(ennemi.GetHealth());
                            }
                        }
                        break;
                    case (int)indexFight.OBJECTS:
                        Console.WriteLine(inventory.GetObjects()[_indexBis]);
                        break;
                    case (int)indexFight.SWITCH:
                        _indexActualFighter = _indexBis;
                        break;
                    case (int)indexFight.ESCAPE:
                        Console.WriteLine("You quit the fight...");
                        _fightMenu = false;
                        fight.QuitFight(mapManager, player);
                        break;
                }

                _ennemyTurn = true;

                if (_ennemyTurn && _fightMenu)
                {
                    Console.SetCursorPosition(10, 28);
                    Random rand = new();
                    int random = rand.Next(1, 100);
                    if (ennemi.GetHealth()>0)
                    {

                    if (random > 50)
                    {
                        //ennemi.atk[rand.Next(0, 3)]
                        Console.WriteLine(ennemi.Name + " hurt you !");
                        team.Fighters[_indexActualFighter].Health -= 10;
                    }
                    else if (random == 1)
                    {
                        Console.WriteLine(ennemi.Name + " escape.");
                        _fightMenu = false;
                    }
                    else
                    {
                        Console.WriteLine(ennemi.Name + " miss his attack !");
                    }
                    }
                    else
                    {

                    fight.QuitFight(mapManager, player);
                    
                    }
                }

                _ennemyTurn = false;
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
                            _indexBisLimMax = 3;
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
                            _indexBisLimMax = inventory._objects.Count - 1;
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
                            _indexBisLimMax = team.Fighters.Length - 1;
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
            string[] atk = team.Fighters[_indexActualFighter].Attack;
            int i = 23;
            foreach (string s in atk)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine(s) ;
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
            
            List<string> obj = inventory.GetObjects();
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
            mates[0] = team.Fighters[0].Name;
            mates[1] = team.Fighters[1].Name;
            mates[2] = team.Fighters[2].Name;

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