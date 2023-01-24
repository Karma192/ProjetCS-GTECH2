using System.Runtime.CompilerServices;
using System.Text;

namespace Program
{
    public class Player
    {
        int _health = 100;
        int _yPos = 10;
        int _xPos = 50;


        public Player()
        {
           
        }
        public int Health
        {
            get => _health;
            set => _health = value;
        }
         public void DrawPlayer()
        {
          
            Console.SetCursorPosition(_xPos, _yPos);
            Console.Write("P");
            
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
