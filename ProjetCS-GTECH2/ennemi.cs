

namespace pokehunter
{
    public class Ennemi
    {
        int _xPos;
        int _yPos;
        string _name;
        public int _health;
        bool _burn;
        int _damage;
        int _debuff = 0;


        public Ennemi(string name, int xPos, int yPos, int heath, int damage)
        {
            _name = name;
            _xPos = xPos;
            _yPos = yPos;
            _health = heath;
            _damage = damage;
        }

        public void DrawEnnemi()
        {
            Console.SetCursorPosition(_xPos, _yPos);
            Console.Write("E");
        }

        public string Name { get { return _name; } }

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
        public void SetBurn(bool burn)
        {
            _burn = burn;
        }
        public void SetDeBuff(int deBuff)
        {
            _debuff = deBuff;
        }

    }
}