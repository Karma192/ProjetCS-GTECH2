

namespace pokehunter
{
    public class Ennemi
    {
        int _xPos;
        int _yPos;
        string _name;
        public int _health;

        public Ennemi(string name, int xPos, int yPos, int heath)
        {
            _name = name;
            _xPos = xPos;
            _yPos = yPos;
            _health = heath;
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
        public int GetHealth()
        {
            return _health;
        }
        public void SetHealth(int health) 
        {
            _health = health;
        }
    }
}