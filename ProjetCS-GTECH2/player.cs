using System.Runtime.CompilerServices;
using System.Text;

namespace pokehunter
{
    public class Player
    {
        int _yPos = 10;
        int _xPos = 50;

        public Player()
        {
           
        }
        
         public void DrawPlayer()
        {
            if (_yPos == 0  || _yPos == 1 && _xPos == 0 || _xPos == 1) 
            {
                _yPos = yPosInit;
                 _xPos =  xPosInit;
            }
            Console.SetCursorPosition(_xPos, _yPos);
            Console.Write("P");
            
        }

        public int GetXPos() 
        {
            return _xPos;
        }

        public int GetYPos() 
        {
            return _yPos;
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
