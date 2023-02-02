

namespace pokehunter
{
    internal class SpawnerEnnemy
    {
        int _quantity;
        List<Ennemi> _ennemis = new();
        Random _rand = new();
        string[] _name = { "Pikachu", "Lucario", "Felinferno", "Evoli", "Chassaing sauvage" };

        public List<Ennemi> GetEnnemis { get => _ennemis; }

        public Ennemi? GetEnnemiCollided(Player player)
        {
            foreach (var e in _ennemis)
            {
                if (player.GetXPos == e.GetXPos && player.GetYPos == e.GetYPos)
                {
                    return e;
                }
            }

            return null;
        }

        public void SetSpawner()
        {
            _quantity = _rand.Next(2, 5);
            for(int i = 0; i < _quantity; i++)
            {
                Ennemi e = new(_name[_rand.Next(_name.Length)], _rand.Next(5, 120), _rand.Next(2, 28), _rand.Next(25, 100), _rand.Next(5, 30));
            }
        }

        public void Spawn()
        {
            foreach (var e in _ennemis)
            {
                e.DrawEnnemi();
            }
        }
    }

    internal class Ennemi
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