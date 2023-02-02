namespace pokehunter
{
    internal class Narrator
    {
        int _progress = 0;
        public int Progress { get => _progress; set => _progress = value; }
    }

    internal class PNJ
    {
        int _posX;
        int _posY;
        char _face = '!';
        int _who;

        enum pnjID
        {
            WOMEN = 0,
            HUSBAND = 1,
        }

        public PNJ(int x, int y, int who)
        {
            _posX = x;
            _posY = y;
            _who = who;
        }


        public void Draw()
        {
            Console.SetCursorPosition(_posX, _posY);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_face);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OnCollide(Player player, ref Narrator nar)
        {
            if (_who == (int)pnjID.WOMEN)
            {
                if (player.GetXPos() == _posX && player.GetYPos() == _posY)
                {
                    if (nar.Progress != 0)
                    {
                        Console.WriteLine("Merci beaucoup ! ^^");
                    }
                    else
                    {
                        Console.WriteLine("Peux-tu aller apporter ça à mon mari dans la cave ?");
                        Console.WriteLine("Merci !");
                    }
                }
            }
            else if (_who == (int)pnjID.HUSBAND)
            {
                if (player.GetXPos() == _posX && player.GetYPos() == _posY)
                {
                    if (nar.Progress == 0)
                    {
                        Console.WriteLine("Ah mon fusil, merci beaucoup !");
                        Console.WriteLine("Je me suis blessé à la jambe, " +
                            "est ce que tu peux m'aider avec ces pokémons stp ?");
                        nar.Progress++;
                    }
                    else
                    {
                        Console.WriteLine("Merci...");
                    }
                }
            }
        }
    }
}