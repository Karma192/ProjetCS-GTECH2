

namespace Program
{
    public class Ennemi
    {
        int _xPos = 20;
        int _yPos = 60;

        public Ennemi()
        {

        }

        public void DrawEnnemi()
        {
            Console.SetCursorPosition(_xPos, _yPos);
            Console.Write("E");
        }

        public int GetXPos() 
        {
            return _xPos;
        }
        public int GetYPos() 
        {
            return _yPos;
        }
    }
}