using System.Numerics;
using System.IO;
using System.Dynamic;

namespace pokehunter
{
    internal class MapManager
    {
        int _actualMap = 2;
        int _postFightMap;
        Map _map = new();

        enum mapIndex
        {
            VILLAGE = 0,
            FOREST = 1,
            CAVE = 2,
            COMBAT = 3,
        }

        public int actualMap() { return _actualMap; }
        public Map GetMap() { return _map; }

        public void DrawMap()
        {
            switch(_actualMap)
            {
                case (int)mapIndex.VILLAGE:
                    _map.InitTab("ascii-art.txt");
                    break;
                case (int)mapIndex.FOREST:
                    _map.InitTab("forestMap.txt");
                    break;
                case (int)mapIndex.CAVE:
                    _map.InitTab("caveMap.txt");
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

        public void ChangeMap(int map)
        {
            if (map == (int)mapIndex.COMBAT)
            {
                _postFightMap = _actualMap;
            }
            _actualMap = map;
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
                            case '#':
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                tab[i, j] = 1;
                                break;
                            case '▲':
                                tab[i, j] = 2;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                break;
                            case '▼':
                                tab[i, j] = 2;
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



