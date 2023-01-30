using pokehunter;

namespace GameSave
{
    internal class Save
    {
        public Save()
        {

        }

        public void DoSave(Player player)
        {
            string saveFile = @"D:\projet c#\ProjetCS-GTECH2\Save.txt";

            string playerPos = $"{player.GetXPos()} {player.GetYPos()}";

            File.WriteAllText(saveFile, playerPos);
        }

        public void ReadSave(Player player)
        {
            string saveFile = @"D:\projet c#\ProjetCS-GTECH2\Save.txt";

            var txt = File.ReadAllText(saveFile);

            //On lit chaque valeur dans un tableau séparé par un espace
            var r = txt.Split(new[] { ' ' });

            int x = Int32.Parse(r[0]);
            int y = Int32.Parse(r[1]);

            player.SetPlayerPos(x, y);
            

        }
    }
}