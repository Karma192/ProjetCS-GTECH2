using System.Numerics;
using System.IO;

namespace pokehunter
{


    internal class MapInit
    {
        public int[,] tab = new int[120, 29];
        int j = 0;

        public void Reset()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void InitTab(string fileName)
        {
            String line;
            try
            {
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
            catch (Exception e)
            {
            }
            finally
            {
            }
        }
    }
}



