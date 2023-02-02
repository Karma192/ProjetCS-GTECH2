using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

namespace pokehunter
{
    public class Player
    {
        [JsonInclude]
        public int _yPos = 10;
        [JsonInclude]
        public int _xPos = 50;

        public string _player = "P";

        public Player()
        {
            
        }

      
        public void DrawPlayer()
        {
            Console.SetCursorPosition(_xPos, _yPos);
            Console.Write(_player);
        }

       

        public int GetXPos() 
        {
            return _xPos;
        }

        public int GetYPos() 
        {
            return _yPos;
        }

        public void SetPlayerPos(int x, int y)
        {
            _xPos= x;
            _yPos= y;
        }


        public char Getinput(ConsoleKeyInfo input)
        {
            
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    return 'U';
                case ConsoleKey.DownArrow:
                    return 'D';
                case ConsoleKey.LeftArrow:
                    return 'L';
                case ConsoleKey.RightArrow:
                    return 'R';
                default:
                    return '0';
            }
        }

        public void Mouvement(char move)
        {
            switch (move)
            {
                case 'U':
                    _yPos = _yPos - 1;
                    break;
                case 'D':
                    _yPos = _yPos + 1;
                    break;
                case 'L':
                    _xPos = _xPos - 1;
                    break;
                case 'R':
                    _xPos = _xPos + 1;
                    break;
                default:
                    break;
            }
        }

    }



}
