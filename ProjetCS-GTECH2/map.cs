using System.Numerics;
using System.IO;
using System.Dynamic;

namespace pokehunter
{
    internal class MapChanger
    {
        int _posX;
        int _posY;
        int _width = 19;
        char _face;
        string _appearence = string.Empty;

        public void SetMapChanger(int x, int y)
        {
            _posX = x;
            _posY = y;
            SetFace();
        }

        void SetFace()
        {
            if (_posY == 1)
            {
                _face = '▲';
            }
            else
            {
                _face = '▼';
            }

            _appearence += " " + _face;

            for (int i = 0; i < _width - 4; i++)
            {
                _appearence += " ";
            }

            _appearence += _face + " ";
        }

        public void DrawMapChanger()
        {
            Console.SetCursorPosition(_posX, _posY);
            Console.Write(_appearence);
        }

        public bool CheckCollide(Player player)
        {
            if (player.GetXPos() >= _posX && player.GetXPos() <= _posX + _width)
            {
                if (player.GetYPos() == _posY)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }

    internal class MapManager
    {
        int _actualMap;
        int _postFightMap;
        MapChanger[] _changers = new MapChanger[2];
        MapChanger _changer1 = new();
        MapChanger _changer2 = new();
        Map _map = new();

        enum mapIndex
        {
            VILLAGE = 0,
            FOREST = 1,
            CAVE = 2,
            COMBAT = 3,
        }

        public int ActualMap() { return _actualMap; }
        public Map GetMap() { return _map; }

        public MapManager()
        {
            _changers.SetValue(_changer1, 0);
            _changers.SetValue(_changer2, 1);

            int i = 0;
            foreach (var changer in _changers)
            {
                changer.SetMapChanger(28, (1 + (i * 25)));
                i++;
            }
        }

        public void DrawMap(Player player, SpawnerEnnemy sp)
        {
            switch (_actualMap)
            {
                case (int)mapIndex.VILLAGE:
                    _map.InitTab("ascii-art.txt");
                    Changers(player, sp);
                    break;
                case (int)mapIndex.FOREST:
                    _map.InitTab("forestMap.txt");
                    Changers(player, sp);
                    break;
                case (int)mapIndex.CAVE:
                    _map.InitTab("caveMap.txt");
                    Changers(player, sp);
                    break;
                case (int)mapIndex.COMBAT:
                    _map.InitTab("combat.txt");
                    break;
            }
        }

        public void QuitFight()
        {
            _actualMap = _postFightMap;

        }

        public void ChangeMap(int map, SpawnerEnnemy sp)
        {
            if (map == (int)mapIndex.COMBAT)
            {
                _postFightMap = _actualMap;
            } else
            {
                sp.SetSpawner();
            }
            _actualMap = map;
        }

        void Changers(Player player, SpawnerEnnemy sp)
        {
            int i = 1;
            foreach (var changer in _changers)
            {
                if (_actualMap == (int)mapIndex.VILLAGE)
                {
                    if (i == -1)
                    {
                        changer.DrawMapChanger();
                    }
                } 
                else if (_actualMap == (int)mapIndex.CAVE)
                {
                    if (i == 1)
                    {
                        changer.DrawMapChanger();
                    }
                } else
                {
                    changer.DrawMapChanger();
                }
                
                if (changer.CheckCollide(player))
                {
                    ChangeMap(_actualMap - i, sp);
                    player.SetPlayerPos(player.GetXPos(), (14 + (11 * i)));
                }
                i = -i;
            }
        }
    }

    internal class Map
    {
        public int[,] tab = new int[120, 29];
        int j = 0;

        private void Reset()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void InitTab(string fileName)
        {
            String line;
            StreamReader sr = new StreamReader(fileName);
            line = sr.ReadLine();
            j = 0;
            while (line != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    char letters = line[i];

                    switch (letters)
                    {
                        case '<':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            tab[i, j] = 1;
                            Reset();
                            break;
                        case '>':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            tab[i, j] = 1;
                            Reset();
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            tab[i, j] = 1;
                            break;
                        case '▲':
                            tab[i, j] = 0;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case '▼':
                            tab[i, j] = 0;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case '.':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            tab[i, j] = 0;
                            Reset();
                            break;
                        case '┐':
                            tab[i, j] = 1;
                            Reset();
                            break;
                        case '─':
                            tab[i, j] = 1;
                            Reset();
                            break;
                        case '│':
                            tab[i, j] = 1;
                            Reset();
                            break;
                        case '┘':
                            tab[i, j] = 1;
                            Reset();
                            break;
                        case '└':
                            tab[i, j] = 1;
                            Reset();
                            break;
                        case '┌':
                            tab[i, j] = 1;
                            Reset();
                            break;
                        default:
                            tab[i, j] = 2;
                            Reset();
                            break;
                    }
                    Console.Write(line[i]);
                }
                j++;

                //write the line to console window

                //Read the next line
                line = sr.ReadLine();
                Console.WriteLine();
            }
            //close the file
            sr.Close();
            //Console.ReadLine();
        }
    }
}



