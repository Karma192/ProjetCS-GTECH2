using System.Numerics;
using pokehunter;

namespace Program 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MapInit map = new MapInit();
            map.InitTab();

            Player p;
            p = new Player();
            p.DrawPlayer();

        }
    }
}
