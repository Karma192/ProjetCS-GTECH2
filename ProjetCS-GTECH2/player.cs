using System.Runtime.CompilerServices;
using System.Text;

namespace pokehunter
{
    public class Player
    {
        int _health = 100;
        int _yPos = 0;
        int _xPos = 0;


        public Player()
        {
           
        }
        public int Health
        {
            get => _health;
            set => _health = value;
        }
         public void DrawPlayer(int yPosInit, int xPosInit)
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

        public void Movement(ConsoleKeyInfo input)
        {
            
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    _yPos = _yPos - 1;
                    break;
                case ConsoleKey.DownArrow:
                    _yPos = _yPos + 1;
                    break;
                case ConsoleKey.LeftArrow:
                    _xPos = _xPos - 1;
                    break;
                case ConsoleKey.RightArrow:
                    _xPos = _xPos + 1;
                    break;
                default:
                    break;
            }
        }


    }



}
