using GameSave;
using pokehunter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetCS_GTECH2
{
    internal class sceneMenu
    {
        string[] _title = new string[6];
        string _start = "START >>";
        string _save = "SAVE >>";
        bool _continue = true;
        int _index = 0;
        //int _indexBis = 0;

        enum indexMenu
        {
            START = 0,
            SAVE = 1,
        }

        public void SceneUpdate(ConsoleKeyInfo input, Save save, Player player, MapManager mapManager, SpawnerEnnemy sp)
        {
            SetTitle();
            AnimTitle();
            while (Continue(input) && _continue)
            {
                ShowTitle();
                input = Console.ReadKey();
                MenuStart(input, save, player, mapManager, sp);
                SaveMenu(input);
            }
        }

        private void SetTitle()
        {
            _title[0] = "__________       __            ___ ___               __                 ";
            _title[1] = "\\______   \\____ |  | __ ____  /   |   \\ __ __  _____/  |_  ___________  ";
            _title[2] = " |     ___/  _ \\|  |/ // __ \\/    ~    \\  |  \\/    \\   __\\/ __ \\_  __ \\ ";
            _title[3] = " |    |  (  <_> )    <\\  ___/\\    Y    /  |  /   |  \\  | \\  ___/|  | \\/ ";
            _title[4] = " |____|   \\____/|__|_ \\\\___  >\\___|_  /|____/|___|  /__|  \\___  >__|   ";
            _title[5] = "                     \\/    \\/       \\/            \\/          \\/       ";
        }

        private void AnimTitle()
        {
            for (int j = 0; j < 3; j++)
            {
                int i = 0;
                foreach (var item in _title)
                {
                    Thread.Sleep(100 - (j * 20));
                    Console.SetCursorPosition(5, i + 1);
                    Console.WriteLine(item);
                    i++;
                }
                Console.Clear();
            }
        }

        private void ShowTitle()
        {
            int i = 0;
            foreach (var item in _title)
            {
                Console.SetCursorPosition(5, i + 1);
                Console.WriteLine(item);
                i++;
            }
        }

        private void MenuStart(ConsoleKeyInfo input, Save save, Player player, MapManager mapManager, SpawnerEnnemy sp)
        {
            HandleKey(input, save, player, mapManager, sp);
            switch (_index)
            {
                case (int)indexMenu.START:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(_start);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(_save);
                    break;
                case (int)indexMenu.SAVE:
                    Console.WriteLine(_start);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(_save);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        private void SaveMenu(ConsoleKeyInfo input)
        {
            Console.SetCursorPosition(15, 10);
            if (_index == (int)indexMenu.SAVE)
            {
                Console.WriteLine("this is the save !");
            } 
            else
            {
                Console.WriteLine("                  ");
            }
        }

        private void HandleKey(ConsoleKeyInfo input, Save save, Player player, MapManager mapManager, SpawnerEnnemy sp)
        {
            switch (input.Key)
            {
                case ConsoleKey.DownArrow:
                    if (_index != 1)
                    {
                        _index++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (_index != 0)
                    {
                        _index--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (_index == 0)
                    {
                        _continue = false;
                    }
                    if (_index == 1)
                    {
                        mapManager.ChangeMap(0, sp);        
                        save.ReadSave(player);
                        _continue= false;
                    }
                    break;
            }
        }

        private static bool Continue(ConsoleKeyInfo input)
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