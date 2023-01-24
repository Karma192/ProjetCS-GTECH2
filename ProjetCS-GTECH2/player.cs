using System.Runtime.CompilerServices;
using System.Text;

namespace Program
{
    public class Player
    {
        int _health = 100;


        public Player()
        {
            Console.WriteLine("Coucou");
        }
        public int Health
        {
            get => _health;
            set => _health = value;
        }
         public void DrawPlayer()
        {
            Console.SetCursorPosition(50, 10);
            Console.Write("P");
            
        }


        public void Deplacement()
        {
            //à faire quand la map est faites 

        }


    }



}
