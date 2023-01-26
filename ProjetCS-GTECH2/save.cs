namespace GameSave
{
    internal class Save
    {
        public Save()
        {

        }

        public void DoSave()
        {
            String saveFile = @"D:\projet c#\ProjetCS-GTECH2\Save.txt";

            File.WriteAllText(saveFile, "Test save");
        }
    }
}