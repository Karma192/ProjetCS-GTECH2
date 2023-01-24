using System.Numerics;

namespace Program 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MapInit map = new MapInit();


            Player p;
            p = new Player();
            Console.WriteLine(p.Health);
            p.Health = 12;

        }
    }
}
