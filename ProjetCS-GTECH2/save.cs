using Fighter;
using MenuPokemon;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pokehunter;
using System.Text.Json;
using System.Text.Json.Nodes;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace GameSave
{
    internal class Save
    {
        public Save()
        {

        }

        public void DoSave(Player player, Team team, MapManager mapManager, Inventory inventory)
        {
            var option = new JsonSerializerOptions()
            {
                IncludeFields = true,
            };
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All, 
            };

            string fileName = @"D:\projet c#\ProjetCS-GTECH2\save\save_fighter.json";
            string jsonString = JsonSerializer.Serialize(team.Fighters, option);
            File.WriteAllText(fileName, jsonString);

            string fileName1 = @"D:\projet c#\ProjetCS-GTECH2\save\save_inventory.json";
            //string jsonString1 = JsonSerializer.Serialize(inventory, option);

            string jsonString1 = JsonConvert.SerializeObject(inventory, settings);
            File.WriteAllText(fileName1, jsonString1);

            string fileName2 = @"D:\projet c#\ProjetCS-GTECH2\save\save_map.json";
            string jsonString2 = JsonSerializer.Serialize(mapManager.ActualMap(), option);
            File.WriteAllText(fileName2, jsonString2);

            string fileName3 = @"D:\projet c#\ProjetCS-GTECH2\save\save_playerpos.json";
            string jsonString3 = JsonSerializer.Serialize(player, option);
            File.WriteAllText(fileName3, jsonString3);
          

        }

        public void ReadSave(Player player)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All,
            };
            string fileName = @"D:\projet c#\ProjetCS-GTECH2\save\save_fighter.json";
            string jsonString = File.ReadAllText(fileName);
            Fighters[] fighters = JsonSerializer.Deserialize<Fighters[]>(jsonString)!;

            string fileName1 = @"D:\projet c#\ProjetCS-GTECH2\save\save_inventory.json";
            string jsonString1 = File.ReadAllText(fileName1);
            //Inventory inventory = JsonSerializer.Deserialize<Inventory>(jsonString1)!;
            Inventory inventory = JsonConvert.DeserializeObject<Inventory>(jsonString1, settings)!;

            string fileName2 = @"D:\projet c#\ProjetCS-GTECH2\save\save_map.json";
            string jsonString2 = File.ReadAllText(fileName2);
            int mapManager = JsonSerializer.Deserialize<int>(jsonString2)!;

            string fileName3 = @"D:\projet c#\ProjetCS-GTECH2\save\save_playerpos.json";
            string jsonString3 = File.ReadAllText(fileName3);
            player = JsonSerializer.Deserialize<Player>(jsonString3)!;

        }
    } 
}